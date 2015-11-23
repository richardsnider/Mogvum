using Assets.Scripts.Abilities;
using Assets.Scripts.Characters;
using Assets.Scripts.Characters.BodyParts;
using Assets.Scripts.Items;
using Assets.Scripts.Regions;

namespace Assets.Scripts.Effects
{
    public abstract class Effect : IEffect
    {
        public IAbility Source;
        public string Name { get; set; }
        public bool IsStackable { get; set; }

        protected Effect(IAbility source, string name = "Default Effect Name", bool isStackable = false)
        {
            Source = source;
            Name = name;
            IsStackable = isStackable;
        }

        public void Apply() { }
        public void UnApply() { }
    }

    public class CharacterEffect : Effect
    {
        public Character Character { get; set; }

        public CharacterEffect(Character character, IAbility source, string name = "Default Effect Name", bool isStackable = false) : base(source, name, isStackable)
        {
            Character = character;
        }
    }

    public class BodyPartEffect : Effect
    {
        public BodyPart BodyPart { get; set; }

        public BodyPartEffect(BodyPart bodyPart, IAbility source, string name = "Default Effect Name", bool isStackable = false) : base(source, name, isStackable)
        {
            BodyPart = bodyPart;
        }
    }

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

    public class RegionCubeEffect : Effect
    {
        public RegionCube RegionCube { get; set; }

        public RegionCubeEffect(RegionCube regionCube, IAbility source, string name = "Default Effect Name", bool isStackable = false) : base(source, name, isStackable)
        {
            RegionCube = regionCube;
        }
    }

    public class ItemEffect : Effect
    {
        public Item Item { get; set; }

        public ItemEffect(Item item, IAbility source, string name = "Default Effect Name", bool isStackable = false) : base(source, name, isStackable)
        {
            Item = item;
        }
    }
}
