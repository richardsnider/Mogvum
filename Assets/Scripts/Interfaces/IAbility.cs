using System.Collections.Generic;
using Assets.Scripts.Characters;

namespace Assets.Scripts.Interfaces
{
    public interface IAbility
    {
        void Perform(Character source, ICollection<ITargetable> targets);
    }
}
