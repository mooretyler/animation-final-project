using UnityEngine;
using System.Collections;

public class FireCannon2 : MonoBehaviour {

	private GameObject cannonBallHandler;
	private GameObject mini_explosion_handler;
	private GameObject medium_explosion_handler;
	private GameObject smoke_handler;
	public float speed;
	private float interval;
	public GameObject ball;
	public GameObject smoke;
	public GameObject mini_explosion;
	public GameObject medium_explosion;

	public AudioSource[] audio;

	private bool cannonBallExploded = false;

	// Use this for initialization
	void Start () {
		speed = GlobalVariables.MIN_FIRING_SPEED;
		interval = 1.015f;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space)) {
			speed *= interval;
			if (speed > GlobalVariables.MAX_FIRING_SPEED) {
				interval = 0.995f;
			}
			if (speed < GlobalVariables.MIN_FIRING_SPEED) {
				interval = 1.015f;
			}
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			cannonBallHandler = (GameObject)Instantiate (ball, transform.position, transform.rotation);
			Rigidbody ballDynamics = cannonBallHandler.GetComponent<Rigidbody> ();
			ballDynamics.AddForce (transform.forward * speed);
			speed = GlobalVariables.MIN_FIRING_SPEED;
			interval = 1.015f;
			mini_explosion_handler = (GameObject)Instantiate (mini_explosion, transform.position, transform.rotation);
			smoke_handler = (GameObject)Instantiate (smoke, transform.position, transform.rotation);
			cannonBallExploded = false;
			audio = transform.GetComponents<AudioSource> ();
			audio [0].Play ();
		}
		GlobalVariables.POWER_LEVEL = speed;

		if (cannonBallHandler != null && Vector3.Distance(cannonBallHandler.transform.position, transform.position) > 5 && cannonBallHandler.GetComponent<Rigidbody>().velocity.magnitude < 15 && !cannonBallExploded) {
			medium_explosion_handler = (GameObject)Instantiate (medium_explosion, cannonBallHandler.transform.position, cannonBallHandler.transform.rotation);
			cannonBallExploded = true;
			audio [1].Play ();
			Floor.RemoveCannonBall (cannonBallHandler, mini_explosion_handler);
			//cannonBallHandler.GetComponent<AssociatedThingsToDestroy> ().addThings (medium_explosion_handler);
		}
	}
}
