using Assets.Scripts.Abilities;
using Assets.Scripts.Characters;
using Assets.Scripts.Characters.BodyParts;
using Assets.Scripts.Items;
using Assets.Scripts.Regions;

namespace Assets.Scripts.Effects
{
    public interface IEffect
    {
        bool IsStackable { get; set; }
        string Name { get; set; }
        void Apply();
        void UnApply();
    }

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

    public interface ICharacterEffect : IEffect
    {
        Character Character { get; }
    }

    public class CharacterEffect : Effect, ICharacterEffect
    {
        public Character Character { get; protected set; }

        public CharacterEffect(IAbility source, string name = "Default Effect Name", bool isStackable = false) : base(source, name, isStackable)
        {
        }
    }

    public interface IBodyPartEffect : IEffect
    {
        BodyPart BodyPart { get; }
    }

    public class BodyPartEffect : Effect, IBodyPartEffect
    {
        public BodyPart BodyPart { get; protected set; }

        public BodyPartEffect(BodyPart bodyPart, IAbility source, string name = "Default Effect Name", bool isStackable = false) : base(source, name, isStackable)
        {
            BodyPart = bodyPart;
        }
    }

    public interface IRegionCubeEffect : IEffect
    {
        RegionCube RegionCube { get; }
    }

    public class RegionCubeEffect : Effect, IRegionCubeEffect
    {
        public RegionCube RegionCube { get; protected set; }

        public RegionCubeEffect(RegionCube regionCube, IAbility source, string name = "Default Effect Name", bool isStackable = false) : base(source, name, isStackable)
        {
            RegionCube = regionCube;
        }
    }

    public interface IItemEffect : IEffect
    {
        Item Item { get; }
    }

    public class ItemEffect : Effect, IItemEffect
    {
        public Item Item { get; protected set; }

        public ItemEffect(Item item, IAbility source, string name = "Default Effect Name", bool isStackable = false) : base(source, name, isStackable)
        {
            Item = item;
        }
    }
}
