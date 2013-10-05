using UnityEngine;
using System.Collections;

public class FoodThrowing : MonoBehaviour {

//initialization variables
private Vector3 foodPosition = new Vector3(0,0,0);	
private bool isDragging = false;
private Vector3 lastMousePosition = new Vector3(0,0,0);
private Vector3 deltaMouse = new Vector3(0,0,0);
private Vector3 temp = new Vector3(0,0,0);
private Vector3 MousePos = new Vector3(0,0,0);
	
public void Update(){
	//set the food position to where the food currently is
	foodPosition = this.transform.position;
	MousePos = Input.mousePosition;
	MousePos.x = MousePos.x - Screen.width/2;
	MousePos.y = MousePos.y - Screen.height/2;

	//checks to see if you are hovering over the food
	if(MousePos.x == foodPosition.x && MousePos.y == foodPosition.y){
			//on click
			if(Input.GetMouseButtonDown(0)){
				isDragging = true;
			}
		}
	
		//drags the food with the mouse
	if(isDragging){
			temp = this.transform.position; 
			temp.x = MousePos.x;
			temp = this.transform.position; 
			temp.y = MousePos.y;
			this.transform.position = temp;
			//records where the last place the food was
			lastMousePosition = MousePos;
		}
		
		//on release
	if(Input.GetMouseButtonUp(0) && isDragging == true){
			//makes a throwing vector
			deltaMouse = MousePos - lastMousePosition;
			isDragging = false;
			
			//throws at speed equal to the difference between the last position and this one
			this.rigidbody.velocity = new Vector3(deltaMouse.x,deltaMouse.y,0);
		}
		
		
		
	}
}

//TODO: Stop dragging past a certain point on the screen
//Put a floor/celing on speed