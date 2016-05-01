using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinnerText : MonoBehaviour {

	private Text winnerText;
	// Use this for initialization
	void Start () {
		winnerText = this.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVariables.hasWINNER) {
			if (GlobalVariables.WINNER == 1) {
				winnerText.text = "Player 1 Wins!";
			}
			if (GlobalVariables.WINNER == 2){
				winnerText.text = "Player 2 Wins!";
			}
			this.transform.localScale = new Vector3 (1, 1, 1);
		}
	}
}
