using UnityEngine;
using System.Collections;

public class PopUpPause : MonoBehaviour {
	
	bool rendered = false;
	// Use this for initialization
	void Start () {
		//keeps the menu invisible at first
		this.gameObject.renderer.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		//reset level
		if(Input.GetMouseButtonDown(0) && rendered){
			Application.LoadLevel(0);
		}
		//unpause
		if(Input.GetMouseButtonDown(1) && rendered){
			Time.timeScale = 1;
			this.gameObject.renderer.enabled = false;
			
		}
		//sound control
		if(Input.GetKey(KeyCode.A) && rendered){
			AudioListener.volume = AudioListener.volume - 0.1f;
			if(AudioListener.volume < 0f){
				AudioListener.volume = 0f;
			}
		}
		if(Input.GetKey(KeyCode.S) && rendered){
			AudioListener.volume = AudioListener.volume + 0.1f;
			if(AudioListener.volume > 1f){
				AudioListener.volume = 1f;
			}
		}
	}
}
