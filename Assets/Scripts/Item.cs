using Assets.Scripts;

public class Item : RegionObject
{
    private Inventory Inventory;
    private bool Grippable;
	private int Weight;
    private int Quantity;
	private int Value;

    public Item()
    {
        Inventory = new Inventory();
    }

    public void AddItem(Item item)
    {
        Inventory.AddItem(item);
    }
}
