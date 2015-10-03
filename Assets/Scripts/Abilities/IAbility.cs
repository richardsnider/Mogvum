using System.Collections.Generic;
using Assets.Scripts.Characters;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.Abilities
{
    public interface IAbility
    {
        void Perform(Character source, ICollection<ITargetable> targets);
    }
}
