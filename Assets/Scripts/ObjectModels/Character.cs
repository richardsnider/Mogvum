using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character
{
    string FirstName, LastName;
	public int Level;
	public string Type;
	public int Size;
    //public int[] Allegiances 

    int Life, LifeRegen;
    int Soul, SoulRegen;
    int Energy;

    public int Strength;
    public int Vitality;

    int Damage;

    int ActionPoints;
	int Accuracy;
	int DodgeRating;
	int BlockRating;

	public void new_character(string firstName, string lastName, int level, string type)
	{
        FirstName = firstName;
        LastName = lastName;
		Level = level;
		Type = type;
	}
}
