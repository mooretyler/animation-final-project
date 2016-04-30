using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControl_Text_Update : MonoBehaviour {

	Text PlayerControlAngleText;

	// Use this for initialization
	void Start () {
		PlayerControlAngleText = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (Cannon1_Start.isActive)
			PlayerControlAngleText.text = "Control: Player 1";
		if (Cannon2_Start.isActive)
			PlayerControlAngleText.text = "Control: Player 2";
	}
}
