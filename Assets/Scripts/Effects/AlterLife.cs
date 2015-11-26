using Assets.Scripts.Abilities;
using Assets.Scripts.Characters.BodyParts;

namespace Assets.Scripts.Effects
{
    public class AlterLife : BodyPartEffect
    {
        public int Amount { get; set; }

        public AlterLife(int amount, BodyPart bodyPart, IAbility source, string name = "Default Effect Name", bool isStackable = false) : base(bodyPart, source, name, isStackable)
        {
            Amount = amount;
        }

        public new void Apply()
        {
            BodyPart.Life.Current += Amount;
        }
    }
}
