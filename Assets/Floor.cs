using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

	void OnTriggerEnter (Collider cannonball){
		print (cannonball.gameObject.name);
		if (cannonball.gameObject.name == "CannonBall(Clone)" || cannonball.gameObject.name == "CannonBallp2(Clone)") {
			if (Player1_Control.isActive) {
				Player1_Control.isActive = false;
				Player2_Control.isActive = true;
			} else {
				Player1_Control.isActive = true;
				Player2_Control.isActive = false;
			}

			Destroy (cannonball.gameObject);
		}
	}
}
