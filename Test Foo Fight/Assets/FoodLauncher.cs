using UnityEngine;
using System.Collections;

public class FoodLauncher : MonoBehaviour {
	
	//assign current food object to be launched
	public GameObject food;
	public float launchspeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		// Casts the ray and get the first game object hit
		Physics.Raycast(ray, out hit);
		if(hit.rigidbody == this.rigidbody){
			if(Input.GetMouseButtonDown(0)){
				food.rigidbody.AddForce(0,launchspeed,0);
			}
		}
	}
}
