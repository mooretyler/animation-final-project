using UnityEngine;
using System.Collections;

public class Cannon1_Start : MonoBehaviour {

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
		isActive = true;
		FiringControl.player1Scripts (isActive);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider cannonball){
		if(cannonball.gameObject.name == "CannonBallp2(Clone)"){
			GameObject p1Camera = GameObject.Find ("P1Camera");
			GameObject p2Camera = GameObject.Find ("P2Camera");
			p1Camera.GetComponent<UnityEngine.Camera> ().enabled = !Cannon1_Start.isActive;
			p2Camera.GetComponent<UnityEngine.Camera> ().enabled = !Cannon2_Start.isActive;
			Destroy (cannonball.gameObject);
			print ("Player 2 Wins!");
//			GameObject cannon = GameObject.Find ("Cannon1");
//			Destroy (cannon);
			Instantiate(explosion, transform.position, transform.rotation);
			transform.GetComponent<AudioSource> ().Play ();
		}

	}
}
