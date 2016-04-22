using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text;

public class PowerTextControl : MonoBehaviour {

	Text PowerLevelDisplay;

	// Use this for initialization
	void Start () {
		PowerLevelDisplay = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		int numOfXs = (int)((GlobalVariables.POWER_LEVEL / GlobalVariables.MAX_FIRING_SPEED) * 10);
		StringBuilder powerDisplay = new StringBuilder("          ");
		for (int i = 0; i < numOfXs; i++)
			powerDisplay.Replace(' ', 'x', i, 1);
		PowerLevelDisplay.text = "Power: [" + powerDisplay.ToString() + "]";
	}
}
