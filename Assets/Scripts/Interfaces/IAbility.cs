using System.Collections.Generic;

namespace Assets.Scripts.Interfaces
{
    public interface IAbility
    {
        void Perform(ICollection<RegionObject> targets, RegionObject source);
    }
}
