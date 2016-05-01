using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGameButton : MonoBehaviour {

	private Button endGame;
	// Use this for initialization
	void Start () {
		endGame = this.GetComponent<Button> ();
		endGame.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVariables.hasWINNER) {
			this.transform.localScale = new Vector3 (1, 1, 1);
			endGame.enabled = true;
		}
	}

	public void onEndGame(){
		Application.Quit ();
	}
}
