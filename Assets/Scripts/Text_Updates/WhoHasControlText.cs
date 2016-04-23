using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WhoHasControlText : MonoBehaviour {

	Text WhoHasControl;

	// Use this for initialization
	void Start () {
		WhoHasControl = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		WhoHasControl.text = "Control:" + GlobalVariables.WHO_HAS_CONTROL_TEXT;
	}
}
