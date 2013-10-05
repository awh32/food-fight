using UnityEngine;
using System.Collections;

public class scale : MonoBehaviour {
	
	public GameObject mainCamera;	
	public Transform parent;
	
	private float dimensionx;
	private float dimensiony;
	
	private float distanceZ;
	private float distanceY;
	private float distancex;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
		parent = transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
