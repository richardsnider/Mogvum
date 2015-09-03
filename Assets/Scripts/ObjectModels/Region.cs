using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class Region
{
	public string terrain_type;
    string name;
	public int row;
	public int column;
	public float y_rotation;
	public RegionData region_data;

	public void new_Region(string a_terrain_type, int a_row, int a_col, float a_y_rotation, string a_name)
	{
			terrain_type = a_terrain_type;
			row = a_row; column = a_col;
			y_rotation = a_y_rotation;
			name = a_name;
	}

	public void update_region()
	{
		terrain_type = region_data.terrain_type;
		row = region_data.row; column = region_data.column;
		y_rotation = region_data.y_rotation;
	}

	public void update_data()
	{
		region_data.terrain_type = terrain_type;
		region_data.row = row; region_data.column = column;
		region_data.y_rotation = y_rotation;
	}

	[System.Serializable]
	public class RegionData
	{
		public string terrain_type;
		public float y_rotation;
		public int row;
		public int column;
	}
}
