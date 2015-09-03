using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

public class World : MonoBehaviour
{
	public static World control;
	public string world_name = "a_name";

	public List<GameObject> organizations = new List<GameObject>();
	public List<GameObject> characters = new List<GameObject>();
	public int size = 10;
	public List<GameObject> regions = new List<GameObject>();

	void Awake()
	{
		if(control == null) { DontDestroyOnLoad(gameObject); control = this; }
		else if(control != this) Destroy(gameObject);
	}

	void Start () { }

	void Update() 
	{	
		if(Input.GetKeyDown(KeyCode.Space)) { Debug.Log("space hit!"); Save_World(); }
	}

	public void New_World(string a_world_name, int a_world_size)
	{
		world_name = a_world_name;
		size = a_world_size;
		int randNumber; 
		string region_name; 
		string[,] terrain_type = new string[size,size];
		Vector3 region_location = new Vector3 (-size, 0, size); 
		Quaternion region_rotation = new Quaternion(); 
		
		for(int current_row = 0; current_row < size; current_row++)
		{
			for(int current_col = 0; current_col < size; current_col++)
			{
				randNumber = UnityEngine.Random.Range(0,3);
				switch(randNumber)
				{	
					case 0: region_rotation = Quaternion.Euler(new Vector3(0,0,0)); break;
					case 1: region_rotation = Quaternion.Euler(new Vector3(0,90,0)); break;
					case 2: region_rotation = Quaternion.Euler(new Vector3(0,180,0)); break;
					case 3: region_rotation = Quaternion.Euler(new Vector3(0,270,0));break;
				}

				randNumber = UnityEngine.Random.Range(0,10);
				switch(randNumber)
				{
					case 0: terrain_type[current_row,current_col] = "ocean_region"; break;
					case 1: terrain_type[current_row,current_col] = "island_region"; break; 
					case 2: terrain_type[current_row,current_col] = "coast_corner_region"; break; 
					case 3: terrain_type[current_row,current_col] = "coast_region"; break; 
	 				case 4: terrain_type[current_row,current_col] = "normal_region"; break; 
					case 5: terrain_type[current_row,current_col] = "forest_region"; break;
	 				case 6: terrain_type[current_row,current_col] = "desert_region"; break; 
					case 7: terrain_type[current_row,current_col] = "mountain_region"; break;
					case 8: terrain_type[current_row,current_col] = "swamp_region"; break; 
	 				case 9: terrain_type[current_row,current_col] = "lake_region"; break; 
	 				case 10: terrain_type[current_row,current_col] = "plains_region"; break;
				}
                region_name = "testworld";

				regions.Add (Resources.Load<GameObject>("Prefabs/Regions/" + terrain_type[current_row, current_col]));
				regions[size*current_row + current_col] = Instantiate(regions[size*current_row+current_col], region_location, region_rotation) as GameObject;

				regions[size*current_row + current_col].GetComponent<Region>().new_Region(terrain_type[current_row,current_col], current_row, current_col, region_rotation.eulerAngles.y, region_name);
				
				region_location.x += 2;
			}
			region_location.z -= 2; 
			region_location.x = -size; 
		}
	}
	
	public void Save_World()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/" + world_name + ".dat");
		
		Debug.Log ("Saving World Data . . .");
		WorldData world_data = new WorldData();
		world_data.name = world_name;
		world_data.size = size;
		
		for(int current_row = 0; current_row < size; current_row++) 
		{
			for(int current_col = 0; current_col < size; current_col++)
			{
				regions[size*current_row + current_col].GetComponent<Region>().update_data();
				world_data.regions.Add(regions[size*current_row + current_col].GetComponent<Region>().region_data);
			} 
		}

		bf.Serialize(file, world_data);
		file.Close(); Debug.Log ("World Data Saved . . .");
	}

	public void Load_World(string a_world_name)
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Open(Application.persistentDataPath + "/" + a_world_name + ".dat", FileMode.Open);

		WorldData world_data = new WorldData();
		Debug.Log("Attempting to deserialize . . .");
		world_data = (WorldData)bf.Deserialize(file);

		Debug.Log("Success! Loading World Data. . .");
		world_name = world_data.name;
		size = world_data.size;
		Region.RegionData region_to_load; 
		Vector3 location = new Vector3(); 
		Quaternion rotation = new Quaternion();
		for(int current_row = 0; current_row < size; current_row++)
		{
			for(int current_col = 0; current_col < size; current_col++)
			{
				region_to_load = world_data.regions[size*current_row + current_col];
				location.x = -size + 2*region_to_load.column;
				location.z = size - 2*region_to_load.row;
				rotation = Quaternion.Euler(new Vector3(0,region_to_load.y_rotation,0)); 

				regions.Add(Resources.Load<GameObject>("Prefabs/Regions/"  + region_to_load.terrain_type));
				regions[size*current_row + current_col] = Instantiate(regions[size*current_row + current_col], location, rotation) as GameObject;
				
				regions[size*current_row + current_col].GetComponent<Region>().region_data = world_data.regions[size*current_row + current_col];
			}
		}
		file.Close(); Debug.Log("Data has been loaded. World's name from data is: " + world_name);
	}

	[System.Serializable]
	public class WorldData
	{
		public string name;
		public int size;
		public List<Region.RegionData> regions = new List<Region.RegionData>();
	}
}
