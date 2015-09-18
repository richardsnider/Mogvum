using Assets.Scripts;
using Assets.Scripts.Enumerables;
using System.Collections.Generic;

public class Region
{
    private World world;
    private int x, y;
    
    private string name;
    private TerrainType terrain;
    private int xSize, ySize, zSize;
    private int elevation;

    //Region needs a Weather class attribute

    private ICollection<RegionCube> cubes;

    public Region(World world, int x, int y, string name = null, TerrainType terrain = TerrainType.Fog,
        ICollection<RegionCube> cubes = null)
    {
        this.world = world;
        this.x = x;
        this.y = y;

        this.name = name ?? "DefaultRegionName";
        this.terrain = terrain;
        this.cubes = cubes ?? new List<RegionCube>();
    }

    public void Day()
    {
        //Have each character in the region take a turn.
    }
}
