using UnityEngine;
using System.Collections;

public class Body_Movement : MonoBehaviour {

	public float move_speed = 0.1f;
	public float rotate_speed = 2.0f;

	//cube-plane determination
	private bool in_neg_x_wall = false; //closest to origin (0)
	private bool in_pos_x_wall = false; //closest to edge (around 3)
	private bool in_neg_z_wall = false; //closest to edge (behind starting postion)
	private bool in_pos_z_wall = false; //cloest to origin (0)
	public float cube_buffer = 0.01f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (0, 0, 1 * move_speed);
		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (0, 0, -1 * move_speed);
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate (0, -1 * rotate_speed, 0);
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate (0, 1 * rotate_speed, 0);

		//player postion
		float p_x = transform.position.x;
		float p_z = transform.position.z;
	}
}
