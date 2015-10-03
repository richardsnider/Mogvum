using System;
using Assets.Scripts.Interfaces;
using UnityEngine;
using Assets.Scripts.Abilities;

namespace Assets.Scripts.Effects
{
    public class Effect : IEffect
    {
        protected string Name;
        private bool IsStackable = false; //This needs to be fixed I think . . . .
        private ITargetable Target; //Need to fix this too . . . 
        private IAbility Source;
        private int Duration; //If Permanent this will be 0 or -1?

        public void Apply()
        {
        }

        public void UnApply()
        {
        }

        public string GetName()
        {
            return Name;
        }

        public bool CanStack()
        {
            return IsStackable;
        }
    }
}
