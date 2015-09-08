using UnityEngine;
using Assets.Scripts.Effects;
using Assets.Scripts.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Scripts
{
    public abstract class RegionObject
    {
        protected Region Region;
        protected RegionCoordinates Coordinates;
        protected ICollection<IEffect> Effects;

        //public RegionObject(RegionCoordinates coordinates)
        //{
        //    Coordinates = coordinates;
        //}

        public void AddEffect(IEffect effect)
        {
           var matchingNamedEffects = Effects.Where(e => e.GetName() == effect.GetName());
           if(matchingNamedEffects == null || effect.CanStack()) {
                Effects.Add(effect);
           }
           else {
                Debug.Log("Effect " + effect.GetName() + "is not stackable and is already on RegionObject.");
           }
        }

        public void RemoveEffect(IEffect effect)
        {
            if (Effects.Contains(effect))
            {
                Effects.Remove(effect);
                //THIS IS UNFINISHED
            }
        }

        public RegionCoordinates GetCoordinates()
        {
            return Coordinates;
        }
    }
}
