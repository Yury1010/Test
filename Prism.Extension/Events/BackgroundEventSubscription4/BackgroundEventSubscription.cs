using System;
using System.Threading.Tasks;

namespace Prism.Events
{
    public class BackgroundEventSubscription<TPayload1, TPayload2, TPayload3, TPayload4> :
      EventSubscription<TPayload1, TPayload2, TPayload3, TPayload4>
    {
        public BackgroundEventSubscription(
          IDelegateReference actionReference,
          IDelegateReference filterReference1,
          IDelegateReference filterReference2,
          IDelegateReference filterReference3,
          IDelegateReference filterReference4)
          : base(actionReference, filterReference1, filterReference2, filterReference3, filterReference4)
        {
        }

        public override void InvokeAction(
          Action<TPayload1, TPayload2, TPayload3, TPayload4> action,
          TPayload1 argument1,
          TPayload2 argument2,
          TPayload3 argument3,
          TPayload4 argument4)
        {
            Task.Run(() => action(argument1, argument2, argument3, argument4));
        }
    }
}
