using UnityEngine;
using System.Collections;

public class EnemyThrowBehavior : MonoBehaviour {
	
	public float timeTilMove;
	public float fireRate;
	
	private float counter;	
	
	// Use this for initialization
	void Start () {		
		counter = 0.0f;
	}
	
	/**
	 * On enable, the counter is reset.
	 */ 
	public void OnEnable() {
		counter = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		counter += Time.deltaTime;
		
		if (counter > timeTilMove) {
			EnterMoveState();
		}
	}
	
	private IEnumerator Throw() {
		yield return new WaitForSeconds(5);
	}
	
	/**
	 * Tell the enemy to move to a different node.
	 */ 
	private void EnterMoveState() {
		gameObject.GetComponent<EnemyMove>().enabled = true;
		gameObject.GetComponent<EnemyThrowBehavior>().enabled = false;
	}
}
