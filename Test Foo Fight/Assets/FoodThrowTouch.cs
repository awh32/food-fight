using UnityEngine;
using System.Collections;

public class FoodThrowTouch : MonoBehaviour {
	
	public static GameObject Player;
	//public bool grabbed = false; 
	public float speed = 0.1f;
	Vector3 lastPosition = Player.transform.position;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate()
    {
		//throw food on flick
         if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			rigidbody.AddForce(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
		}
		
		//move the food object with the player so the don't look disconnected
		if(Player.transform.position.x > lastPosition.x){
			Vector3 temp = this.transform.position;
			temp.x = temp.x + 1;
			this.transform.position = temp;
		}
		
		if(Player.transform.position.x < lastPosition.x){
			Vector3 temp = this.transform.position;
			temp.x = temp.x - 1;
			this.transform.position = temp;
		}
		//update player position	
		lastPosition = Player.transform.position;
		
    }
}
