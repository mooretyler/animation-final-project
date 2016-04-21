using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpDown_Text_Update : MonoBehaviour {

	Text UpDownAngleText;

	// Use this for initialization
	void Start () {
		UpDownAngleText = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		UpDownAngleText.text = GlobalVariables.UP_DOWN_ANGLE;
	}
}
