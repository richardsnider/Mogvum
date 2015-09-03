using UnityEngine;

namespace Assets.Scripts.Abilities
{
    public class Move
    {
        public static void Execute(Character character, SpaceCube src, SpaceCube dest)
        {
            //character.Stats.Energy -= character.Skills.Kinesis.Move;
            //character.Stats.Energy -= character.Skills.Kinesis.GetLevel();

            src.occupants.Remove(character);
            dest.occupants.Add(character);
            Debug.Log(character.FirstName);
        }
    }
}
