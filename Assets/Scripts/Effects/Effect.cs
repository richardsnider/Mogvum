using System;
using Assets.Scripts.Enumerables;
using Assets.Scripts.Interfaces;
using UnityEngine;
using Assets.Scripts.Abilities;

namespace Assets.Scripts.Effects
{
    public class Effect : IEffect
    {
        protected string Name;
        private bool IsStackable = false; //This needs to be fixed I think . . . .
        private RegionObject Target = new Character(); //Need to fix this too . . . 
        private IAbility Source;
        private TargetType TargetType;
        private int Duration; //If Permanent this will be 0 or -1?

        public void Apply()
        {
            var coords = Target.GetCoordinates();
            Debug.Log("Base effect class has been applied to RegionObject at "
                + coords.X() + "," + coords.Y() + "," + coords.Z() + "/n");
        }

        public void UnApply()
        {
            var coords = Target.GetCoordinates();
            Debug.Log("Base effect class has been removed from RegionObject at "
               + coords.X() + "," + coords.Y() + "," + coords.Z() + "/n");
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
