using UnityEngine;
using System.Collections;

public class FoodThrowing : MonoBehaviour {
	//these will ideally be inputed based on flick speed and then put at a celing
	public static float x = 1;
	public static float y = 2;
	public static float z = 3;
	Vector3 project = new Vector3(x,y,z);
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	//this will be on touch eventually, once I can do that
	void FixedUpdate () {
		rigidbody.AddForce(project,ForceMode.Force);
	}
	
	//I forget how to do this, it doesn't work.
	void onCollisionEnter(){
		//check to see if hit target
		//yes? increment score and run splat animation or some shit like that
		//no?
		Destroy(this);
	}
	
}