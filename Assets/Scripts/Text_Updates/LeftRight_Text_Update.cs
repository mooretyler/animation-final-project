using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftRight_Text_Update : MonoBehaviour {

	Text LeftRightAngleText;

	// Use this for initialization
	void Start () {
		LeftRightAngleText = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		LeftRightAngleText.text = GlobalVariables.LEFT_RIGHT_ANGLE;
	}
}
