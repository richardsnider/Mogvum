using System;
using Assets.Scripts.Enumerables;
using Assets.Scripts.Interfaces;
using UnityEngine;
using Assets.Scripts.Abilities;

namespace Assets.Scripts.Effects
{
    public class Effect : IEffect
    {
        public int Id;
        public string Name;
        public bool IsStackable;
        public RegionObject Target;
        public IAbility Source;
        public TargetType TargetType;
        public int Duration; //If Permanent this will be 0 or -1?

        public void ApplyEffect()
        {
            Target.Effects
        }

        public void RemoveEffect()
        {
            throw new NotImplementedException();
        }
    }
}
