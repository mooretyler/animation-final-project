using UnityEngine;
using System.Collections;

public class Cannon1_Start : MonoBehaviour {

	//starting location randomization
	public float MAX_X_STARTING_DISPLACEMENT = 35f;
	public float MAX_Z_STARTING_DISPLACEMENT = 10f;

	// Use this for initialization
	void Start () {
		//initialize random start location on x/z axis
		float randomXDisplacement = Random.Range(-MAX_X_STARTING_DISPLACEMENT, MAX_X_STARTING_DISPLACEMENT);
		float randomZDisplacement = Random.Range(-MAX_Z_STARTING_DISPLACEMENT, MAX_Z_STARTING_DISPLACEMENT);
		transform.Translate (randomXDisplacement, randomZDisplacement, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider cannonball){
		if(cannonball.gameObject.name == "CannonBallp2(Clone)"){
			GameObject p1Camera = GameObject.Find ("P1Camera");
			GameObject p2Camera = GameObject.Find ("P2Camera");
			p1Camera.GetComponent<UnityEngine.Camera> ().enabled = !Player1_Control.isActive;
			p2Camera.GetComponent<UnityEngine.Camera> ().enabled = !Player2_Control.isActive;
			Destroy (cannonball.gameObject);
			print ("Player 2 Wins!");
		}

	}
}
