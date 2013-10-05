using UnityEngine;
using System.Collections;

public class NodeBehavior : MonoBehaviour {
	
	public bool isOccupied;	
	
	// Use this for initialization
	private void Start () {
		isOccupied = false;
	}	
	
	public void ToggleOccupied() {
		isOccupied = ! isOccupied;
	}	
}
