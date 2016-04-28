using UnityEngine;
using System.Collections;

public class PlatformP2 : MonoBehaviour {

	void OnTriggerEnter (Collider cannonball){
		if (cannonball.gameObject.name == "CannonBall(Clone)") {
			GameObject p1Camera = GameObject.Find ("P1Camera");
			GameObject p2Camera = GameObject.Find ("P2Camera");
			p1Camera.GetComponent<UnityEngine.Camera> ().enabled = !Player1_Control.isActive;
			p2Camera.GetComponent<UnityEngine.Camera> ().enabled = !Player2_Control.isActive;
			//cannonball.GetComponent<UnityEngine.Camera> ().enabled = Player1_Control.isActive;
			Destroy (cannonball.gameObject);
			print ("Player 1 Wins!");
		}
	}
}
