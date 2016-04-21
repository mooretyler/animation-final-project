using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public float rotation_speed = 2.0f;

	private float swing_angle = 0.0f;
	private float elevate_angle = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButton (0)) {
			transform.localRotation = Quaternion.identity;

			float swing_request = Input.GetAxis ("Mouse Y") * rotation_speed;
			float elevate_request = Input.GetAxis ("Mouse X") * rotation_speed;

			swing_angle += swing_request;
			elevate_angle += elevate_request;
			
			transform.Rotate (-swing_angle, elevate_angle, 0);

			print ("X: " + transform.localEulerAngles.x + ", swing_angle: " + swing_angle + " Z: " + transform.localEulerAngles.z);
			print ("Y: " + transform.localEulerAngles.y + ", elevation_angle: " + elevate_angle + " Z: " + transform.localEulerAngles.z);

		} else {
			transform.localRotation = Quaternion.identity;
			if (elevate_angle < 0)
				elevate_angle += 1f;
			if (elevate_angle > 0)
				elevate_angle -= 1f;
			if (swing_angle < 0)
				swing_angle += 1f;
			if (swing_angle > 0)
				swing_angle -= 1f;

			//float temp_swing = swing_angle * -1 * .05f;
			//float temp_elevation = elevate_angle * -1 *.05f;

			//transform.Rotate (temp_swing, temp_elevation, 0);
			transform.Rotate (-swing_angle, elevate_angle, 0);

			//swing_angle += temp_swing;
			//elevate_angle += temp_elevation;

			if (Mathf.Abs (swing_angle) < 1 && Mathf.Abs (elevate_angle) < 1) {
				transform.localRotation = Quaternion.identity;
				swing_angle = 0;
				elevate_angle = 0;
			}

		}
	
	}
}
