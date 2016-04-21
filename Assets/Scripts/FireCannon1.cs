using UnityEngine;
using System.Collections;

public class FireCannon1 : MonoBehaviour {

	private GameObject cannonBall;
	public float speed;
	public GameObject ball;
	// Use this for initialization
	void Start () {  
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			cannonBall = (GameObject) Instantiate (ball, transform.position, transform.rotation);
			Rigidbody ballDynamics = cannonBall.GetComponent<Rigidbody> ();
			ballDynamics.AddForce (transform.forward * speed);
		}
	}
}
