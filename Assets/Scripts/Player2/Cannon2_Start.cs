using UnityEngine;
using System.Collections;

public class Cannon2_Start : MonoBehaviour {

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
}
