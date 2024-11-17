using Prism.Properties;
using System;
using System.Collections;
using System.Linq;

namespace Prism.Events
{
    public class PubSubEvent<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> : EventBase
    {
        public SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> action)
        {
            return Subscribe(action, 0);
        }

        public virtual SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> action,
          Predicate<TPayload1> filter1,
          Predicate<TPayload2> filter2,
          Predicate<TPayload3> filter3,
          Predicate<TPayload4> filter4,
          Predicate<TPayload5> filter5)
        {
            return Subscribe(action, 0, false, filter1, filter2, filter3, filter4, filter5);
        }

        public SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> action,
          ThreadOption threadOption)
        {
            return Subscribe(action, threadOption, false);
        }

        public SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> action,
          bool keepSubscriberReferenceAlive)
        {
            return Subscribe(action, 0, keepSubscriberReferenceAlive);
        }

        public SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> action,
          ThreadOption threadOption,
          bool keepSubscriberReferenceAlive)
        {
            return Subscribe(action, threadOption, keepSubscriberReferenceAlive, null, null, null, null, null);
        }

        public virtual SubscriptionToken Subscribe(
          Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> action,
          ThreadOption threadOption,
          bool keepSubscriberReferenceAlive,
          Predicate<TPayload1> filter1,
          Predicate<TPayload2> filter2,
          Predicate<TPayload3> filter3,
          Predicate<TPayload4> filter4,
          Predicate<TPayload5> filter5)
        {
            IDelegateReference actionReference = new DelegateReference(action, keepSubscriberReferenceAlive);
            IDelegateReference filterReference1 = filter1 == null ? new DelegateReference(new Predicate<TPayload1>(delegate { return true; }), true) : new DelegateReference(filter1, keepSubscriberReferenceAlive);
            IDelegateReference filterReference2 = filter2 == null ? new DelegateReference(new Predicate<TPayload2>(delegate { return true; }), true) : new DelegateReference(filter2, keepSubscriberReferenceAlive);
            IDelegateReference filterReference3 = filter3 == null ? new DelegateReference(new Predicate<TPayload3>(delegate { return true; }), true) : new DelegateReference(filter3, keepSubscriberReferenceAlive);
            IDelegateReference filterReference4 = filter4 == null ? new DelegateReference(new Predicate<TPayload4>(delegate { return true; }), true) : new DelegateReference(filter4, keepSubscriberReferenceAlive);
            IDelegateReference filterReference5 = filter5 == null ? new DelegateReference(new Predicate<TPayload5>(delegate { return true; }), true) : new DelegateReference(filter5, keepSubscriberReferenceAlive);
            EventSubscription<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> eventSubscription;
            switch (threadOption)
            {
                case ThreadOption.PublisherThread:
                    eventSubscription = new EventSubscription<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5>(actionReference, filterReference1, filterReference2, filterReference3, filterReference4, filterReference5);
                    break;
                case ThreadOption.UIThread:
                    if (SynchronizationContext == null)
                        throw new InvalidOperationException(Resources.EventAggregatorNotConstructedOnUIThread);
                    eventSubscription = new DispatcherEventSubscription<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5>(actionReference, filterReference1, filterReference2, filterReference3, filterReference4, filterReference5, SynchronizationContext);
                    break;
                case ThreadOption.BackgroundThread:
                    eventSubscription = new BackgroundEventSubscription<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5>(actionReference, filterReference1, filterReference2, filterReference3, filterReference4, filterReference5);
                    break;
                default:
                    eventSubscription = new EventSubscription<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5>(actionReference, filterReference1, filterReference2, filterReference3, filterReference4, filterReference5);
                    break;
            }
            return InternalSubscribe(eventSubscription);
        }

        public virtual void Publish(TPayload1 payload1, TPayload2 payload2, TPayload3 payload3, TPayload4 payload4, TPayload5 payload5) => InternalPublish(new object[] { payload1, payload2, payload3, payload4, payload5 });

        public virtual void Unsubscribe(
          Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> subscriber)
        {
            lock (Subscriptions)
            {
                IEventSubscription ieventSubscription = Subscriptions.Cast<EventSubscription<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5>>().FirstOrDefault(evt => evt.Action == subscriber);
                if (ieventSubscription == null)
                    return;
                Subscriptions.Remove(ieventSubscription);
            }
        }

        public virtual bool Contains(
          Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> subscriber)
        {
            IEventSubscription ieventSubscription;
            lock (Subscriptions)
                ieventSubscription = Subscriptions.Cast<EventSubscription<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5>>().FirstOrDefault(evt => evt.Action == subscriber);
            return ieventSubscription != null;
        }
    }
}
