using Prism.Properties;
using System;
using System.Linq;

namespace Prism.Events
{
    public class PubSubEvent<TPayload1, TPayload2> : EventBase
    {
        public SubscriptionToken Subscribe(Action<TPayload1, TPayload2> action) => Subscribe(action, (ThreadOption)0);

        public virtual SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2> action,
          Predicate<TPayload1> filter1,
          Predicate<TPayload2> filter2)
        {
            return Subscribe(action, 0, false, filter1, filter2);
        }

        public SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2> action,
          ThreadOption threadOption)
        {
            return Subscribe(action, threadOption, false);
        }

        public SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2> action,
          bool keepSubscriberReferenceAlive)
        {
            return Subscribe(action, 0, keepSubscriberReferenceAlive);
        }

        public SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2> action,
          ThreadOption threadOption,
          bool keepSubscriberReferenceAlive)
        {
            return Subscribe(action, threadOption, keepSubscriberReferenceAlive, null, null);
        }

        public virtual SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2> action,
          ThreadOption threadOption,
          bool keepSubscriberReferenceAlive,
          Predicate<TPayload1> filter1,
          Predicate<TPayload2> filter2)
        {
            IDelegateReference actionReference = new DelegateReference(action, keepSubscriberReferenceAlive);
            IDelegateReference filterReference1 = filter1 == null ? new DelegateReference(new Predicate<TPayload1>(delegate { return true; }), true) : (IDelegateReference)new DelegateReference(filter1, keepSubscriberReferenceAlive);
            IDelegateReference filterReference2 = filter2 == null ? new DelegateReference(new Predicate<TPayload2>(delegate { return true; }), true) : (IDelegateReference)new DelegateReference(filter2, keepSubscriberReferenceAlive);
            EventSubscription<TPayload1, TPayload2> eventSubscription;
            switch (threadOption)
            {
                case ThreadOption.PublisherThread:
                    eventSubscription = new EventSubscription<TPayload1, TPayload2>(actionReference, filterReference1, filterReference2);
                    break;
                case ThreadOption.UIThread:
                    if (SynchronizationContext == null)
                        throw new InvalidOperationException(Resources.EventAggregatorNotConstructedOnUIThread);
                    eventSubscription = new DispatcherEventSubscription<TPayload1, TPayload2>(actionReference, filterReference1, filterReference2, SynchronizationContext);
                    break;
                case ThreadOption.BackgroundThread:
                    eventSubscription = new BackgroundEventSubscription<TPayload1, TPayload2>(actionReference, filterReference1, filterReference2);
                    break;
                default:
                    eventSubscription = new EventSubscription<TPayload1, TPayload2>(actionReference, filterReference1, filterReference2);
                    break;
            }
            return InternalSubscribe(eventSubscription);
        }

        public virtual void Publish(TPayload1 payload1, TPayload2 payload2) => InternalPublish(new object[2] { payload1, payload2 });

        public virtual void Unsubscribe(Action<TPayload1, TPayload2> subscriber)
        {
            lock (Subscriptions)
            {
                IEventSubscription ieventSubscription = Subscriptions.Cast<EventSubscription<TPayload1, TPayload2>>().FirstOrDefault(evt => evt.Action == subscriber);
                if (ieventSubscription == null)
                    return;
                Subscriptions.Remove(ieventSubscription);
            }
        }

        public virtual bool Contains(Action<TPayload1, TPayload2> subscriber)
        {
            IEventSubscription ieventSubscription;
            lock (Subscriptions)
                ieventSubscription = Subscriptions.Cast<EventSubscription<TPayload1, TPayload2>>().FirstOrDefault(evt => evt.Action == subscriber);
            return ieventSubscription != null;
        }
    }
}
