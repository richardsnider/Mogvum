using Assets.Scripts;

public class Character
{
    public string FirstName, LastName;
    public CharacterStats Stats;
    public Skill Skill;

	public void NewCharacter(string firstName, string lastName)
	{
        FirstName = firstName;
        LastName = lastName;
	}

    public void TakeTurn() { }
    public void PerformAbility() { }
}
