using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//if swiping = true
		//check if swipe trail hit enemy projectile
		//yes?
		//block()
		//no?
		//end
	}
	
	void block(){
		//run animation
		//Destroy (enemy projectile);
	}
	
	void onCollisionenter(){
		gotHit();	
	}
	
	void gotHit(){
		//decrement score/lives
	}
}
