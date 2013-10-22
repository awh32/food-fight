using UnityEngine;
using System.Collections;

public class HUDPause : MonoBehaviour {
	
	public GameObject pauseMenu;
	// Use this for initialization
	void Start () {
		//Load art mesh
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			pauseMenu.SetActive(true);

		}
	}
}
