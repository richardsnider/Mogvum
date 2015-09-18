using System.Collections.Generic;

namespace Assets.Scripts.Interfaces
{
    public interface IAbility
    {
        void Perform(Character source, ICollection<ITargetable> targets);
    }
}
