using System.Collections.Generic;
using Assets.Scripts.Enumerables;
using Assets.Scripts;
using Assets.Scripts.Interfaces;

public class RegionCube
{
    private Region region;
    private int x, y, z;
	private Matter matter;
    private ICollection<IEffect> effects;
	private ICollection<Character> occupants;
    private Inventory inventory;
    private int cover, lighting;

    public RegionCube(Region region, int x, int y, int z, Matter matter = Matter.Vacuum, ICollection < IEffect> effects = null, 
        ICollection<Character> occupants = null, Inventory inventory = null, int cover = 0, int lighting = 100) 
    {
        this.region = region;
        this.x = x;
        this.y = y;
        this.z = z;
        this.matter = matter;
        this.effects = effects ?? new List<IEffect>();
        this.occupants = occupants ?? new List<Character>();
        this.inventory = inventory ?? new Inventory(0, 0, true);
        this.cover = cover;
        this.lighting = lighting;
    }

    public bool AddEffect(IEffect effect)
    {
        if (!effects.Contains(effect))
        {
            effects.Add(effect);
            return true;
        }
        else return false;
    }

    public IEffect RemoveEffect(IEffect effect)
    {
        if (effects.Contains(effect))
        {
            effects.Remove(effect);
            return effect;
        }
        else return null;
    }

    public bool AddOccupant(Character character)
    {
        if ((character.Stats.Size <= CharacterSize.Tiny || occupants.Count == 0)
            && !occupants.Contains(character))
        {
            occupants.Add(character);
            return true;
        }
        else return false;
    }

    public Character RemoveOccupant(Character character)
    {
        if (occupants.Contains(character))
        {
            occupants.Remove(character);
            return character;
        }
        else return null;
    }

}
