using System.Collections.Generic;

namespace Assets.Scripts.Interfaces
{
    public interface IAbility
    {
        void Perform(RegionObject source, ICollection<RegionObject> targets);
    }
}
