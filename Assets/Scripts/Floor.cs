using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

	void OnTriggerEnter (Collider cannonball){
		if (cannonball.gameObject.name == "CannonBall(Clone)") {
			Player1_Control.isActive = false;
			Player2_Control.isActive = true;
			GameObject p1Camera = GameObject.Find ("P1Camera");
			GameObject p2Camera = GameObject.Find ("P2Camera");
			p1Camera.GetComponent<UnityEngine.Camera> ().enabled = Player1_Control.isActive;
			p2Camera.GetComponent<UnityEngine.Camera> ().enabled = Player2_Control.isActive;
			//cannonball.GetComponent<UnityEngine.Camera> ().enabled = Player1_Control.isActive;
			Destroy (cannonball.gameObject);
		}
		if(cannonball.gameObject.name == "CannonBallp2(Clone)"){
			Player1_Control.isActive = true;
			Player2_Control.isActive = false;
			GameObject p1Camera = GameObject.Find ("P1Camera");
			GameObject p2Camera = GameObject.Find ("P2Camera");
			p1Camera.GetComponent<UnityEngine.Camera> ().enabled = Player1_Control.isActive;
			p2Camera.GetComponent<UnityEngine.Camera> ().enabled = Player2_Control.isActive;
			Destroy (cannonball.gameObject);
		}
			
	}
}
