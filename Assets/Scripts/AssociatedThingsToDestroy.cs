using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AssociatedThingsToDestroy : MonoBehaviour {

	private List<GameObject> theThings;

	public AssociatedThingsToDestroy(params GameObject[] thingsToDestroy) {
		this.theThings = new List<GameObject> ();
		foreach (GameObject gb in thingsToDestroy) {
			this.theThings.Add(gb);
		}
	}

	public void addThings (params GameObject[] thingsToDestroy) {
		foreach (GameObject gb in thingsToDestroy) {
			this.theThings.Add (gb);
		}
	}

	public void deleteAssociatedThings () {
		foreach (GameObject gb in this.theThings) {
			Destroy (gb);
		}
	}
}
