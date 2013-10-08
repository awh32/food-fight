using UnityEngine;
using System.Collections;

public class scale : MonoBehaviour {
	
	public GameObject mainCamera;	
	public Transform parent;
	public float targetScale;
	public float shrinkSpeed;
	public float scaler;
	
	private float dimensionx;
	private float dimensiony;
	
	private float distanceZ;
	public float distanceY;
	private float distanceX;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindGameObjectWithTag("MainCamera");		
	}
	
	// Update is called once per frame
	void Update () {
		distanceX = mainCamera.transform.position.x;
		distanceY = transform.position.y;
		
		FindScale();
		transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(targetScale, targetScale, targetScale), Time.deltaTime * shrinkSpeed);
	}
	
	private void FindScale() {
		targetScale = (1 / distanceY) * scaler; 
	}
}
