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
}
