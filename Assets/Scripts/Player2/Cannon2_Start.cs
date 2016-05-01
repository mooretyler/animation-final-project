using UnityEngine;
using System.Collections;

public class Cannon2_Start : MonoBehaviour {

	public GameObject explosion;

	//starting location randomization
	public float MAX_X_STARTING_DISPLACEMENT = 35f;
	public float MAX_Z_STARTING_DISPLACEMENT = 10f;
	public static bool isActive;
	// Use this for initialization
	void Start () {
		//initialize random start location on x/z axis
		float randomXDisplacement = Random.Range(-MAX_X_STARTING_DISPLACEMENT, MAX_X_STARTING_DISPLACEMENT);
		float randomZDisplacement = Random.Range(-MAX_Z_STARTING_DISPLACEMENT, MAX_Z_STARTING_DISPLACEMENT);
		transform.Translate (randomXDisplacement, randomZDisplacement, 0);
		isActive = false;
		FiringControl.player2Scripts (isActive);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider cannonball){
		if (cannonball.gameObject.name == "CannonBall(Clone)") {
			GameObject p1Camera = GameObject.Find ("P1Camera");
			GameObject p2Camera = GameObject.Find ("P2Camera");
			p1Camera.GetComponent<UnityEngine.Camera> ().enabled = !Cannon1_Start.isActive;
			p2Camera.GetComponent<UnityEngine.Camera> ().enabled = !Cannon2_Start.isActive;
			FiringControl.player1Scripts (false);
			FiringControl.player2Scripts (false);
			Destroy (cannonball.gameObject);
			Instantiate (explosion, transform.position, transform.rotation);
			transform.GetComponent<AudioSource> ().Play ();
			GlobalVariables.WINNER = 1;
			GlobalVariables.hasWINNER = true;
		}
	}
}
