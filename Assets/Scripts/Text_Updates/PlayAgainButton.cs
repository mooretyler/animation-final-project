using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour {

	private Button playAgain;
	// Use this for initialization
	void Start () {
		playAgain = this.GetComponent<Button> ();
		playAgain.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVariables.hasWINNER) {
			this.transform.localScale = new Vector3 (1, 1, 1);
			playAgain.enabled = true;
		}
			
	}

	public void onPlayAgain(){
		GlobalVariables.hasWINNER = false;
		GlobalVariables.WINNER = 0;
		SceneManager.LoadScene ("battleship");
	}
}
