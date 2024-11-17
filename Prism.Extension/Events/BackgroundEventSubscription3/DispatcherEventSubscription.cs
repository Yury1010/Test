using System;
using System.Threading;

namespace Prism.Events
{
    public class DispatcherEventSubscription<TPayload1, TPayload2, TPayload3> :
      EventSubscription<TPayload1, TPayload2, TPayload3>
    {
        private readonly SynchronizationContext _syncContext;

        public DispatcherEventSubscription(
          IDelegateReference actionReference,
          IDelegateReference filterReference1,
          IDelegateReference filterReference2,
          IDelegateReference filterReference3,
          SynchronizationContext context)
          : base(actionReference, filterReference1, filterReference2, filterReference3)
        {
            _syncContext = context;
        }

        public override void InvokeAction(
          Action<TPayload1, TPayload2, TPayload3> action,
          TPayload1 argument1,
          TPayload2 argument2,
          TPayload3 argument3)
        {
            _syncContext.Post(o => action((TPayload1)((object[])o)[0], (TPayload2)((object[])o)[1], (TPayload3)((object[])o)[2]), new object[3] { argument1, argument2, argument3 });
        }
    }
}
