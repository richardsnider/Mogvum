using Assets.Scripts;
using Assets.Scripts.Enumerables;
using System.Collections.Generic;

public class Region
{
    private World world;
    private int x, y;
    
    private string name;
    private TerrainType terrain;
    private ICollection<RegionCube> cubes;
    private ICollection<Character> occupants;
    private ICollection<Item> items;
    private ICollection<Vehicle> vehicles;

    public Region(World world, int x, int y, string name = null, TerrainType terrain = TerrainType.Fog,
        ICollection<RegionCube> cubes = null, ICollection<Character> occupants = null, 
        ICollection<Item> items = null, ICollection<Vehicle> vehicles = null)
    {
        this.world = world;
        this.x = x;
        this.y = y;

        this.name = name ?? "generateName";
        this.terrain = terrain;
        this.cubes = cubes; // ?? GenerateCubes
        this.occupants = occupants; // ?? GenerateOccupants
        this.items = items; // ?? GenerateItems
        this.vehicles = vehicles;
    }

    public void Day()
    {
        foreach(var character in occupants)
        {
            character.TakeTurn();
        }
    }

    public void RemoveOccupant(Character character)
    {
        occupants.Remove(character);
    }

    public void AddOccupant(Character character)
    {
        occupants.Add(character);
    }
}
