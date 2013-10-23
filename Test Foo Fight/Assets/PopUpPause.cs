using UnityEngine;
using System.Collections;

public class PopUpPause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Application.LoadLevel(0);
		}
		if(Input.GetMouseButtonDown(1)){
			Time.timeScale = 1;
			this.gameObject.renderer.enabled = false;
			
		}
	}
}
