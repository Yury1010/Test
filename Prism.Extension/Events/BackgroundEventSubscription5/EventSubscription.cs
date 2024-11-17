using Prism.Properties;
using System;
using System.Globalization;

namespace Prism.Events
{
    public class EventSubscription<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> :
      IEventSubscription
    {
        private readonly IDelegateReference _actionReference;
        private readonly IDelegateReference _filterReference1;
        private readonly IDelegateReference _filterReference2;
        private readonly IDelegateReference _filterReference3;
        private readonly IDelegateReference _filterReference4;
        private readonly IDelegateReference _filterReference5;

        public EventSubscription(
          IDelegateReference actionReference,
          IDelegateReference filterReference1,
          IDelegateReference filterReference2,
          IDelegateReference filterReference3,
          IDelegateReference filterReference4,
          IDelegateReference filterReference5)
        {
            if (actionReference == null)
                throw new ArgumentNullException(nameof(actionReference));
            if (!(actionReference.Target is Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5>))
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidDelegateRerefenceTypeException, typeof(Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5>).FullName), nameof(actionReference));
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
            if (filterReference4 == null)
                throw new ArgumentNullException(nameof(filterReference4));
            if (!(filterReference4.Target is Predicate<TPayload4>))
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidDelegateRerefenceTypeException, typeof(Predicate<TPayload4>).FullName), nameof(filterReference4));
            if (filterReference5 == null)
                throw new ArgumentNullException(nameof(filterReference5));
            if (!(filterReference5.Target is Predicate<TPayload5>))
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidDelegateRerefenceTypeException, typeof(Predicate<TPayload5>).FullName), nameof(filterReference5));
            _actionReference = actionReference;
            _filterReference1 = filterReference1;
            _filterReference2 = filterReference2;
            _filterReference3 = filterReference3;
            _filterReference4 = filterReference4;
            _filterReference5 = filterReference5;
        }

        public Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> Action => (System.Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5>)_actionReference.Target;

        public Predicate<TPayload1> Filter1 => (Predicate<TPayload1>)_filterReference1.Target;

        public Predicate<TPayload2> Filter2 => (Predicate<TPayload2>)_filterReference2.Target;

        public Predicate<TPayload3> Filter3 => (Predicate<TPayload3>)_filterReference3.Target;

        public Predicate<TPayload4> Filter4 => (Predicate<TPayload4>)_filterReference4.Target;

        public Predicate<TPayload5> Filter5 => (Predicate<TPayload5>)_filterReference5.Target;

        public SubscriptionToken SubscriptionToken { get; set; }

        public virtual Action<object[]> GetExecutionStrategy()
        {
            Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> action = Action;
            Predicate<TPayload1> filter1 = Filter1;
            Predicate<TPayload2> filter2 = Filter2;
            Predicate<TPayload3> filter3 = Filter3;
            Predicate<TPayload4> filter4 = Filter4;
            Predicate<TPayload5> filter5 = Filter5;
            return action != null && filter1 != null && filter2 != null && filter3 != null && filter4 != null && filter5 != null ? (Action<object[]>)(arguments =>
            {
                TPayload1 payload1 = default;
                TPayload2 payload2 = default;
                TPayload3 payload3 = default;
                TPayload4 payload4 = default;
                TPayload5 payload5 = default;
                if (arguments != null && arguments.Length > 4 && arguments[0] != null && arguments[1] != null && arguments[2] != null && arguments[3] != null && arguments[4] != null)
                {
                    payload1 = (TPayload1)arguments[0];
                    payload2 = (TPayload2)arguments[1];
                    payload3 = (TPayload3)arguments[2];
                    payload4 = (TPayload4)arguments[3];
                    payload5 = (TPayload5)arguments[4];
                }
                if (!filter1(payload1) || !filter2(payload2) || !filter3(payload3) || !filter4(payload4) || !filter5(payload5))
                    return;
                InvokeAction(action, payload1, payload2, payload3, payload4, payload5);
            }) : null;
        }

        public virtual void InvokeAction(
          Action<TPayload1, TPayload2, TPayload3, TPayload4, TPayload5> action,
          TPayload1 argument1,
          TPayload2 argument2,
          TPayload3 argument3,
          TPayload4 argument4,
          TPayload5 argument5)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));
            action(argument1, argument2, argument3, argument4, argument5);
        }
    }
}
