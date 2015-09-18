using System.Collections.Generic;

namespace Assets.Scripts.Interfaces
{
    interface IAbilityToggle : IAbility
    {
        void TurnOn(Character source, ICollection<ITargetable> target);
        void TurnOff(Character source, ICollection<ITargetable> target);
    }
}
