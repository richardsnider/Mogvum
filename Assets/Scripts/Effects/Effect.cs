using System;
using Assets.Scripts.Enumerables;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Effects
{
    public class Effect : IEffect
    {
        public int Id;
        public string Name;
        public System.Object Target;
        public TargetType TargetType;
        public int Duration; //If Permanent this will be 0 or -1?

        public void ApplyEffect()
        {
            throw new NotImplementedException();
        }

        public void RemoveEffect()
        {
            throw new NotImplementedException();
        }
    }
}
