using Prism.Properties;
using System;
using System.Globalization;

namespace Prism.Events
{
    public class EventSubscription<TPayload1, TPayload2> : IEventSubscription
    {
        private readonly IDelegateReference _actionReference;
        private readonly IDelegateReference _filterReference1;
        private readonly IDelegateReference _filterReference2;

        public EventSubscription(
          IDelegateReference actionReference,
          IDelegateReference filterReference1,
          IDelegateReference filterReference2)
        {
            if (actionReference == null)
                throw new ArgumentNullException(nameof(actionReference));
            if (!(actionReference.Target is Action<TPayload1, TPayload2>))
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidDelegateRerefenceTypeException, typeof(Action<TPayload1, TPayload2>).FullName), nameof(actionReference));
            if (filterReference1 == null)
                throw new ArgumentNullException(nameof(filterReference1));
            if (!(filterReference1.Target is Predicate<TPayload1>))
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidDelegateRerefenceTypeException, typeof(Predicate<TPayload1>).FullName), nameof(filterReference1));
            if (filterReference2 == null)
                throw new ArgumentNullException(nameof(filterReference2));
            if (!(filterReference2.Target is Predicate<TPayload2>))
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidDelegateRerefenceTypeException, typeof(Predicate<TPayload2>).FullName), nameof(filterReference2));
            _actionReference = actionReference;
            _filterReference1 = filterReference1;
            _filterReference2 = filterReference2;
        }

        public Action<TPayload1, TPayload2> Action => (Action<TPayload1, TPayload2>)_actionReference.Target;

        public Predicate<TPayload1> Filter1 => (Predicate<TPayload1>)_filterReference1.Target;

        public Predicate<TPayload2> Filter2 => (Predicate<TPayload2>)_filterReference2.Target;

        public SubscriptionToken SubscriptionToken { get; set; }

        public virtual Action<object[]> GetExecutionStrategy()
        {
            Action<TPayload1, TPayload2> action = Action;
            Predicate<TPayload1> filter1 = Filter1;
            Predicate<TPayload2> filter2 = Filter2;
            return action != null && filter1 != null && filter2 != null ? (Action<object[]>)(arguments =>
            {
                TPayload1 payload1 = default;
                TPayload2 payload2 = default;
                if (arguments != null && arguments.Length > 1 && arguments[0] != null && arguments[1] != null)
                {
                    payload1 = (TPayload1)arguments[0];
                    payload2 = (TPayload2)arguments[1];
                }
                if (!filter1(payload1) || !filter2(payload2))
                    return;
                InvokeAction(action, payload1, payload2);
            }) : null;
        }

        public virtual void InvokeAction(
          Action<TPayload1, TPayload2> action,
          TPayload1 argument1,
          TPayload2 argument2)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));
            action(argument1, argument2);
        }
    }
}
