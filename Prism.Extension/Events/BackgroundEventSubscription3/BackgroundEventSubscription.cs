using System;
using System.Threading.Tasks;

namespace Prism.Events
{
    public class BackgroundEventSubscription<TPayload1, TPayload2, TPayload3> :
      EventSubscription<TPayload1, TPayload2, TPayload3>
    {
        public BackgroundEventSubscription(
          IDelegateReference actionReference,
          IDelegateReference filterReference1,
          IDelegateReference filterReference2,
          IDelegateReference filterReference3)
          : base(actionReference, filterReference1, filterReference2, filterReference3)
        {
        }

        public override void InvokeAction(
          Action<TPayload1, TPayload2, TPayload3> action,
          TPayload1 argument1,
          TPayload2 argument2,
          TPayload3 argument3)
        {
            Task.Run(() => action(argument1, argument2, argument3));
        }
    }
}
