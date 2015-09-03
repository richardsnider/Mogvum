using System.Collections.Generic;

namespace Assets.Scripts.Interfaces
{
    interface IAbilityToggle : IAbility
    {
        void TurnOn(RegionObject source, ICollection<RegionObject> target);
        void TurnOff(RegionObject source, ICollection<RegionObject> target);
    }
}
