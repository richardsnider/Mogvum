using Assets.Scripts;
using Assets.Scripts.Interfaces;
using System.Collections.Generic;

public class Character : RegionObject
{
    public string FirstName, LastName;
    public CharacterStats Stats;
    public Skill Skill;
    public Anatomy Anatomy;
    public Inventory Inventory;

	public void GenerateCharacter()
	{
        FirstName = "Name Gneeraakje";
        LastName = "bleeeblooo";
	}

    public void LoadCharacter(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void TakeTurn() { }
    public void UseAbility(IAbility ability, ICollection<RegionObject> targets)
    {
        ability.Perform(this, targets);
    }
}
