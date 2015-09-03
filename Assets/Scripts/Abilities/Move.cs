using System;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Abilities
{
    public class Move : IAbility
    {
        public static void Perform(SpaceCube character, SpaceCube src, SpaceCube dest)
        {
            //character.Stats.Energy -= character.Skills.Kinesis.Move;
            //character.Stats.Energy -= character.Skills.Kinesis.GetLevel();

            src.occupants.Remove(character);
            dest.occupants.Add(character);
            Debug.Log(character.FirstName);
        }

    }
}
