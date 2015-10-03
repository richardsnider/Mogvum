using System;
using System.Collections.Generic;
using Assets.Scripts.Characters;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Regions;
using UnityEngine;

namespace Assets.Scripts.Abilities
{
    public class Move : Ability
    {
        public void Perform(Character source, ICollection<RegionCube> target)
        {
            //THIS MIGHT NEED SOME WORK. NOT SURE IF I CAN CHANGE THE PARAMETERS.

            //IF I HAVE AN IAbility, it might call the base class Perform method and not this one. Hopefully not.


            //character.Stats.Energy -= character.Skills.Kinesis.Move;
            //character.Stats.Energy -= character.Skills.Kinesis.GetLevel();

            //src.occupants.Remove(character);
            //dest.occupants.Add(character);
            //Debug.Log(character.FirstName);
        }
    }
}
