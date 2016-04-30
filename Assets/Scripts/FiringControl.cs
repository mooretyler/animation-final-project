using UnityEngine;
using System.Collections;

public static class FiringControl
{
	private static bool player1InControl = true;
	private static bool player2InControl = false;

	private static Object sync = new Object(); //multi-thread lock key

	private static bool permissionToFire = true;
	private static void InitiateCountdownTimer () {
		lock (sync) {
			permissionToFire = false;
		}
		new WaitForSeconds(GlobalVariables.FIRING_SEC_TIME_DELAY);
		lock (sync) {
			permissionToFire = true;
		}
	}

	public static bool PermissionToFire() {
		lock (sync) {
			return permissionToFire;
		}
	}
	public static bool isPlayer1InControl() {
		lock (sync) {
			return player1InControl;
		}
	}

	public static bool isPlayer2InControl() {
		lock (sync) {
			return player2InControl;
		}
	}

	public static void RevokeFiringControl()
	{
		lock (sync) {
			player1InControl = !player1InControl;
			player2InControl = !player2InControl;
		}
		InitiateCountdownTimer ();
	}

	public static void player1Scripts(bool player1Active){
		GameObject player = GameObject.Find ("Player1");
		GameObject cannon = GameObject.Find ("Cannon1");
		GameObject launchSite = GameObject.Find ("LaunchC1");
		player.GetComponent<Player1_Control> ().enabled = player1Active;
		cannon.GetComponent<Cannon1_Controls> ().enabled = player1Active;
		launchSite.GetComponent<FireCannon1> ().enabled = player1Active;
	}
	public static void player2Scripts(bool player2Active){
		GameObject player = GameObject.Find ("Player2");
		GameObject cannon = GameObject.Find ("Cannon2");
		GameObject launchSite = GameObject.Find ("LaunchC2");
		player.GetComponent<Player2_Control> ().enabled = player2Active;
		cannon.GetComponent<Cannon2_Controls> ().enabled = player2Active;
		launchSite.GetComponent<FireCannon2> ().enabled = player2Active;
	}
}
