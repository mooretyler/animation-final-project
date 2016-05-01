using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BackgroundScript : MonoBehaviour {
	public Texture backgroundImage;
	private GUIStyle titleFont;
	void OnGUI(){
		titleFont = new GUIStyle ();
		titleFont.fontSize = 40;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundImage);
		GUI.Label (new Rect (Screen.width/2 - 100,40, 200, 60), "Cannon Strike!", titleFont);
		if (GUI.Button (new Rect (40, Screen.height / 2, 100, 50), "Play Game")) {
			SceneManager.LoadScene ("battleship");
		}
	}
}
