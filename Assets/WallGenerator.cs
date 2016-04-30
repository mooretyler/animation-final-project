using UnityEngine;
using System.Collections;

public class WallGenerator : MonoBehaviour {

	private GameObject wall_block_builder;
	public GameObject wall_block;

	// Use this for initialization
	void Start () {
		//create middle wall bottom layer
		float wall_length = 50;
		float current_length = -wall_length;
		float wall_height = 10;
		float current_height = 0;
		float wall_z = 45;
		float current_z = -45;

		while (current_length < wall_length && current_height < wall_height && current_z <= wall_z) {
			Vector3 location = new Vector3 ((float)current_length, (float)current_height, (float)current_z);
			build_wall (location);
			current_length = wall_block_builder.transform.position.x + 6;
			if (current_length >= wall_length) {
				current_height = wall_block_builder.transform.position.y + 8f;
				current_length = -wall_length;
				if (current_height >= wall_height) {
					current_z += 45;
					current_height = 0;
					current_length = -wall_length;
				}
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}

	void build_wall(Vector3 location)
	{
		wall_block_builder = (GameObject)Instantiate (wall_block, location, transform.rotation);
	}
}
