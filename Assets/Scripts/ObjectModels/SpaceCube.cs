using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpaceCube
{
	public int row; 
	public int column;
	public int height_level;
	public int material; //air, water, dirt, stone, wood
	public bool occupyable;
	public Character occupant;
	public int cover;
	public int lighting;

	public void new_Space_Cube(int row_, int col, int height)
	{
		row = row_;
		column = col;
		height_level = height;
	}

	public void update_space_cube()
	{
	}
	
	public void update_data()
	{
	}
	
	[System.Serializable]
	public class SpaceCubeData
	{
		public int row; 
		public int column;
		public int height_level;
		public int material;
		public bool occupyable;
		public Character occupant;
		public int cover;
		public int lighting;
	}

}
