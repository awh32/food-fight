using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public GameObject FirendlyFood;
	Vector3 tilt = Input.acceleration;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp;
		
		if(tilt.x > 0){
			temp = this.transform.position;
			temp.x = temp.x+1;
			this.transform.position = temp;
		}
		if(tilt.x < 0){
			temp = this.transform.position;
			temp.x = temp.x-1;
			this.transform.position = temp;
		}
		
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
