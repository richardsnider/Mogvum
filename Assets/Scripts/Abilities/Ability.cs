using System.Collections.Generic;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Effects;

namespace Assets.Scripts.Abilities
{
    public class Ability : IAbility
    {
        bool counter;
        //var for special ability vs Item ability vs regular skill ability ?

        public void Perform(Character source, ICollection<ITargetable> targets)
        {
            IEffect effect = new Effect();
            foreach(var target in targets)
            {
                //target.AddEffect(effect);
                effect.Apply();
            }
        }
    }
}
