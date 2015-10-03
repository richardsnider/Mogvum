using System.Collections.Generic;
using Assets.Scripts.Characters;

namespace Assets.Scripts.Abilities
{
    interface IAbilityToggle : IAbility
    {
        void TurnOn(Character source, ICollection<ITargetable> target);
        void TurnOff(Character source, ICollection<ITargetable> target);
    }
}
