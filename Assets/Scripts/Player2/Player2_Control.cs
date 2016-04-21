using UnityEngine;
using System.Collections;

public class Player2_Control : MonoBehaviour {

	public float MAX_LEFT_ANGLE = 50f;
	public float MAX_RIGHT_ANGLE = 50f;
	public float LEFT_RIGHT_ROTATION_SPEED = 1.0f;
	public float leftRotation;
	public float rightRotation;
	public static bool isActive;
	// Use this for initialization
	void Start () {
		leftRotation = 0f;
		rightRotation = 0f;
		isActive = false;
	}

	// Update is called once per frame
	void Update () {
		//right rotation
		if (isActive) {
			if (Input.GetKey (KeyCode.D) && rightRotation < MAX_RIGHT_ANGLE) {
				transform.Rotate (0, 0, 1 * LEFT_RIGHT_ROTATION_SPEED);
				rightRotation += LEFT_RIGHT_ROTATION_SPEED;
				leftRotation -= LEFT_RIGHT_ROTATION_SPEED;
			}
			//left rotation
			if (Input.GetKey (KeyCode.A) && leftRotation < MAX_LEFT_ANGLE) {
				transform.Rotate (0, 0, -1 * LEFT_RIGHT_ROTATION_SPEED);
				leftRotation += LEFT_RIGHT_ROTATION_SPEED;
				rightRotation -= LEFT_RIGHT_ROTATION_SPEED;
			}
		}

	}
}
