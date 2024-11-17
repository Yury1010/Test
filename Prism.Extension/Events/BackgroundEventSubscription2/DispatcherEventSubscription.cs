using System;
using System.Threading;

namespace Prism.Events
{
    public class DispatcherEventSubscription<TPayload1, TPayload2> :
      EventSubscription<TPayload1, TPayload2>
    {
        private readonly SynchronizationContext _syncContext;

        public DispatcherEventSubscription(
          IDelegateReference actionReference,
          IDelegateReference filterReference1,
          IDelegateReference filterReference2,
          SynchronizationContext context)
          : base(actionReference, filterReference1, filterReference2)
        {
            _syncContext = context;
        }

        public override void InvokeAction(
          Action<TPayload1, TPayload2> action,
          TPayload1 argument1,
          TPayload2 argument2)
        {
            _syncContext.Post(o => action((TPayload1)((object[])o)[0], (TPayload2)((object[])o)[1]), new object[2] { argument1, argument2 });
        }
    }
}
