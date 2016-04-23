using UnityEngine;
using System.Collections;

public class Body_Movement : MonoBehaviour {

	public float move_speed = 3.0f;
	public float rotate_speed = 2.0f;

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
	}
}
