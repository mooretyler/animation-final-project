using UnityEngine;
using System.Collections;

public class Cannon_Control : MonoBehaviour {

	//maximum amount of cannon rotation
	public float MAX_DOWN_ANGLE = 10f;
	public float MAX_UP_ANGLE = 20f;


	//cannon rotation speed

	public float UP_DOWN_ROTATION_SPEED = 1.0f;

	//markers for how much rotation has occured
	public float downRotation;
	public float upRotation;


	// Use this for initialization
	void Start () {
		//initialize rotation values
		downRotation = 0f;
		upRotation = 0f;

	}

	// Update is called once per frame
	void Update () {
		
		//down rotation
		if (Input.GetKey (KeyCode.S) && downRotation < MAX_DOWN_ANGLE) {
			transform.Rotate (1 * UP_DOWN_ROTATION_SPEED, 0, 0);
			downRotation += UP_DOWN_ROTATION_SPEED;
			upRotation -= UP_DOWN_ROTATION_SPEED;
		}
		//up rotation
		if (Input.GetKey (KeyCode.W) && upRotation < MAX_UP_ANGLE) {
			transform.Rotate (-1 * UP_DOWN_ROTATION_SPEED, 0, 0);
			upRotation += UP_DOWN_ROTATION_SPEED;
			downRotation -= UP_DOWN_ROTATION_SPEED;
		}
	}
}
