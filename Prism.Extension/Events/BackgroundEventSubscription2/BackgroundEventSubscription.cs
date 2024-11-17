using System;
using System.Threading.Tasks;

namespace Prism.Events
{
    public class BackgroundEventSubscription<TPayload1, TPayload2> :
      EventSubscription<TPayload1, TPayload2>
    {
        public BackgroundEventSubscription(
          IDelegateReference actionReference,
          IDelegateReference filterReference1,
          IDelegateReference filterReference2)
          : base(actionReference, filterReference1, filterReference2)
        {
        }

        public override void InvokeAction(
          Action<TPayload1, TPayload2> action,
          TPayload1 argument1,
          TPayload2 argument2)
        {
            Task.Run(() => action(argument1, argument2));
        }
    }
}
