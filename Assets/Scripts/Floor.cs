using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

	void OnTriggerEnter (Collider cannonball){
		if (cannonball.gameObject.name == "CannonBall(Clone)") {
			Cannon1_Start.isActive = false;
			Cannon2_Start.isActive = true;
			GameObject p1Camera = GameObject.Find ("P1Camera");
			GameObject p2Camera = GameObject.Find ("P2Camera");
			p1Camera.GetComponent<UnityEngine.Camera> ().enabled = Cannon1_Start.isActive;
			p2Camera.GetComponent<UnityEngine.Camera> ().enabled = Cannon2_Start.isActive;
			FiringControl.player1Scripts (Cannon1_Start.isActive);
			FiringControl.player2Scripts (Cannon2_Start.isActive);
			//cannonball.GetComponent<UnityEngine.Camera> ().enabled = Player1_Control.isActive;
			Destroy (cannonball.gameObject);
		}
		if(cannonball.gameObject.name == "CannonBallp2(Clone)"){
			Cannon1_Start.isActive = true;
			Cannon2_Start.isActive = false;
			GameObject p1Camera = GameObject.Find ("P1Camera");
			GameObject p2Camera = GameObject.Find ("P2Camera");
			p1Camera.GetComponent<UnityEngine.Camera> ().enabled = Cannon1_Start.isActive;
			p2Camera.GetComponent<UnityEngine.Camera> ().enabled = Cannon2_Start.isActive;
			FiringControl.player1Scripts (Cannon1_Start.isActive);
			FiringControl.player2Scripts (Cannon2_Start.isActive);
			Destroy (cannonball.gameObject);
		}
			
	}
}
