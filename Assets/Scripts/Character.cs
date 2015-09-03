using Assets.Scripts;
using Assets.Scripts.Interfaces;
using System.Collections.Generic;

public class Character : RegionObject
{
    public string FirstName, LastName;
    public ICollection<IEffect> Effects;
    public CharacterStats Stats;
    public Skill Skill;

	public void GenerateCharacter()
	{
        FirstName = 'Name Gneera;akje';
        LastName = 'bleeeblooo';
	}

    public void LoadCharacter(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void TakeTurn() { }
    public void PerformAbility() { }
}
