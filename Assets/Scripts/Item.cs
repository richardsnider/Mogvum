using Assets.Scripts;
using Assets.Scripts.Interfaces;
using System.Collections.Generic;

public class Item
{
    Inventory inventory; //Handle to containing inventory.
    private string name;
    private bool grippable;
	private int Weight;
    private int Quantity;
	private int Value;

    public Item(RegionCoordinates coordinates, ICollection<IEffect> effects = null, Inventory inventory = null)
    {
    }

    public string GetName()
    {
        return name;
    }
}
