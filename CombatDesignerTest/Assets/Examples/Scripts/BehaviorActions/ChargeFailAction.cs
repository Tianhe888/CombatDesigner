using UnityEngine;

namespace CombatDesigner
{
    public class ChargeFailAction : IBehaviorAction
    {

        public override void Execute(ActorModel model)
        {
            if (!Input.GetKey(model.currentBehavior.inputKey))
            {
                model.EndBehavior();
            }
        }
    }
}