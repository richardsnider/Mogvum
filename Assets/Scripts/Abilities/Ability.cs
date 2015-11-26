using System.Collections.Generic;
using Assets.Scripts.Characters;
using Assets.Scripts.Effects;

namespace Assets.Scripts.Abilities
{
    public class Ability : IAbility
    {
        bool counter;
        //var for special ability vs Item ability vs regular skill ability ?

        public void Perform(Character source, ICollection<ITargetable> targets)
        {
            //foreach(var target in targets)
            //{
            //    //target.addeffect
            //}
        }
    }

    public interface IAbility
    {
        void Perform(Character source, ICollection<ITargetable> targets);
    }

    interface IAbilityToggle : IAbility
    {
        void TurnOn(Character source, ICollection<ITargetable> target);
        void TurnOff(Character source, ICollection<ITargetable> target);
    }
}
