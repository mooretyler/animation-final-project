using UnityEngine;
using System.Collections;

public class FireCannon1 : MonoBehaviour {

	private GameObject cannonBall;
	public float speed;
	private float interval;
	public GameObject ball;

	// Use this for initialization
	void Start () {
		speed = GlobalVariables.MIN_FIRING_SPEED;
		interval = 1.015f;
	}

	// Update is called once per frame
	void Update () {
		if (Player1_Control.isActive) {
			GlobalVariables.WHO_HAS_CONTROL_TEXT = "Player 1";

			if (Input.GetKey (KeyCode.Space)) {
				speed *= interval;
				if (speed > GlobalVariables.MAX_FIRING_SPEED) {
					interval = 0.995f;
				}
				if (speed < 100.0f) {
					interval = 1.015f;
				}
				print (speed);
			}
			if (Input.GetKeyUp (KeyCode.Space)) {
				cannonBall = (GameObject)Instantiate (ball, transform.position, transform.rotation);
				Rigidbody ballDynamics = cannonBall.GetComponent<Rigidbody> ();
				ballDynamics.AddForce (transform.forward * speed);
				speed = GlobalVariables.MIN_FIRING_SPEED;
				interval = 1.015f;
			}
			GlobalVariables.POWER_LEVEL = speed;
		}
	}

	///
	/// FAILED ATTEMPT AT MULTITHREADING :( 
	///

//	// Use this for initialization
//	void Start () {
//		speed = GlobalVariables.MIN_FIRING_SPEED;
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (FiringControl.isPlayer1InControl() && FiringControl.PermissionToFire()) {
//			if (Input.GetKey (KeyCode.Space)) {
//				selectSpeed ();
//				print (speed);
//			}
//			if (Input.GetKeyUp (KeyCode.Space)) {
//				fire ();
//			}
//		}
//	}
//
//	void selectSpeed() {
//		if (speed < GlobalVariables.MAX_FIRING_SPEED)
//			speed += GlobalVariables.FIRING_VELOCITY_CHANGE;
//		else
//			speed = GlobalVariables.MIN_FIRING_SPEED;
//	}
//
//	void fire () {
//		cannonBall = (GameObject)Instantiate (ball, transform.position, transform.rotation);
//		Rigidbody ballDynamics = cannonBall.GetComponent<Rigidbody> ();
//		ballDynamics.AddForce (transform.forward * speed);
//		FiringControl.RevokeFiringControl ();
//		speed = GlobalVariables.MIN_FIRING_SPEED;
//	}
}
