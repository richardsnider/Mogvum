using UnityEngine;
using Assets.Scripts.Effects;
using Assets.Scripts.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Scripts
{
    public abstract class RegionObject
    {
        private Region Region;
        private RegionCoordinates Coordinates;
        private ICollection<IEffect> Effects;

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
            var matchingNamedEffects = Effects.Where(e => e.GetName() == effect.GetName());
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
