using UnityEngine;
using Assets.Scripts.Effects;
using Assets.Scripts.Interfaces;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public abstract class RegionObject
    {
        public Region Region;
        RegionCoordinates Coordinates;
        ICollection<IEffect> Effects;

        public void AddEffect(Effect effect)
        {
           if(!Effects.Contains(effect) || effect.IsStackable) {
                Effects.Add(effect);
           }
           else {
                Debug.Log("Effect " + effect.Name + "is not stackable and is already on RegionObject.");
           }
        }

        public void RemoveEffect(Effect effect)
        {
            if(Effects.Contains(effect))
            {
                Effects.Remove(effect); //Need to remove just 1 effect, there could be multiple.
            }
        }
    }
}
