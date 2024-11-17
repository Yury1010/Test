using Prism.Properties;
using System;
using System.Globalization;

namespace Prism.Events
{
    public class EventSubscription<TPayload1, TPayload2, TPayload3> : IEventSubscription
    {
        private readonly IDelegateReference _actionReference;
        private readonly IDelegateReference _filterReference1;
        private readonly IDelegateReference _filterReference2;
        private readonly IDelegateReference _filterReference3;

        public EventSubscription(
          IDelegateReference actionReference,
          IDelegateReference filterReference1,
          IDelegateReference filterReference2,
          IDelegateReference filterReference3)
        {
            if (actionReference == null)
                throw new ArgumentNullException(nameof(actionReference));
            if (!(actionReference.Target is Action<TPayload1, TPayload2, TPayload3>))
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidDelegateRerefenceTypeException, typeof(Action<TPayload1, TPayload2, TPayload3>).FullName), nameof(actionReference));
            if (filterReference1 == null)
                throw new ArgumentNullException(nameof(filterReference1));
            if (!(filterReference1.Target is Predicate<TPayload1>))
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidDelegateRerefenceTypeException, typeof(Predicate<TPayload1>).FullName), nameof(filterReference1));
            if (filterReference2 == null)
                throw new ArgumentNullException(nameof(filterReference2));
            if (!(filterReference2.Target is Predicate<TPayload2>))
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidDelegateRerefenceTypeException, typeof(Predicate<TPayload2>).FullName), nameof(filterReference2));
            if (filterReference3 == null)
                throw new ArgumentNullException(nameof(filterReference3));
            if (!(filterReference3.Target is Predicate<TPayload3>))
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidDelegateRerefenceTypeException, typeof(Predicate<TPayload3>).FullName), nameof(filterReference3));
            _actionReference = actionReference;
            _filterReference1 = filterReference1;
            _filterReference2 = filterReference2;
            _filterReference3 = filterReference3;
        }

        public Action<TPayload1, TPayload2, TPayload3> Action => (Action<TPayload1, TPayload2, TPayload3>)_actionReference.Target;

        public Predicate<TPayload1> Filter1 => (Predicate<TPayload1>)_filterReference1.Target;

        public Predicate<TPayload2> Filter2 => (Predicate<TPayload2>)_filterReference2.Target;

        public Predicate<TPayload3> Filter3 => (Predicate<TPayload3>)_filterReference3.Target;

        public SubscriptionToken SubscriptionToken { get; set; }

        public virtual Action<object[]> GetExecutionStrategy()
        {
            Action<TPayload1, TPayload2, TPayload3> action = Action;
            Predicate<TPayload1> filter1 = Filter1;
            Predicate<TPayload2> filter2 = Filter2;
            Predicate<TPayload3> filter3 = Filter3;
            return action != null && filter1 != null && filter2 != null && filter3 != null ? (Action<object[]>)(arguments =>
            {
                TPayload1 payload1 = default;
                TPayload2 payload2 = default;
                TPayload3 payload3 = default;
                if (arguments != null && arguments.Length > 2 && arguments[0] != null && arguments[1] != null && arguments[2] != null)
                {
                    payload1 = (TPayload1)arguments[0];
                    payload2 = (TPayload2)arguments[1];
                    payload3 = (TPayload3)arguments[2];
                }
                if (!filter1(payload1) || !filter2(payload2) || !filter3(payload3))
                    return;
                InvokeAction(action, payload1, payload2, payload3);
            }) : null;
        }

        public virtual void InvokeAction(
          Action<TPayload1, TPayload2, TPayload3> action,
          TPayload1 argument1,
          TPayload2 argument2,
          TPayload3 argument3)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));
            action(argument1, argument2, argument3);
        }
    }
}
