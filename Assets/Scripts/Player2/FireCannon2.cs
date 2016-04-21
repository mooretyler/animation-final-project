using UnityEngine;
using System.Collections;

public class FireCannon2 : MonoBehaviour {

	private GameObject cannonBall;
	public float speed;
	private float interval;
	public GameObject ball;
	// Use this for initialization
	void Start () {
		speed = 100.0f;
		interval = 1.015f;
	}

	// Update is called once per frame
	void Update () {
		
		if (Player2_Control.isActive) {
			if (Input.GetKey (KeyCode.Space)) {
				speed *= interval;
				if (speed > 10000.0f) {
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
				speed = 100.0f;
			}
		}
	}
}
