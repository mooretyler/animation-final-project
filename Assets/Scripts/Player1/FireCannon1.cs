using UnityEngine;
using System.Collections;

public class FireCannon1 : MonoBehaviour {

	private GameObject cannonBall;
	public float speed;
	private float interval;
	public GameObject ball;
	private bool maxReached;
	// Use this for initialization
	void Start () {
		speed = 100.0f;
		interval = 1.015f;
		maxReached = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Player1_Control.isActive) {
			if (Input.GetKey (KeyCode.Space) && !maxReached) {
				speed *= interval;
				if (speed > 10000.0f) {
					maxReached = true;
				}
				print (speed);
			}
			if (Input.GetKeyUp (KeyCode.Space) || maxReached) {
				cannonBall = (GameObject)Instantiate (ball, transform.position, transform.rotation);
				Rigidbody ballDynamics = cannonBall.GetComponent<Rigidbody> ();
				ballDynamics.AddForce (transform.forward * speed);
				speed = 100.0f;
				maxReached = false;
			}
		}
	}
}
