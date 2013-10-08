/**
  * Timothy Sesler
  * tds45@case.edu
  * 5 October 2013
  */ 

using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	
	public float moveSpeed;								// The enemy's movement speed		
	public GameObject[] availableNodes;					// The nodes that this enemy can move to
	
	public Vector3 currentPosition;					// The current position of this enemy
	public Vector3 newPosition;						// The position that this enemy will move to
	public GameObject currentNode;						// The node that this enemy is currently at
	public GameObject nextNode;						// The node that this enemy will move to
	
	/**
	 * Find available nodes on awake.
	 */ 
	public void Awake() {
		FindNodes();
		ChooseNextNode();
	}
	
	/**
	 * Once enabled, choose the next node and set positions.
	 */
	public void OnEnable() {
		currentNode = nextNode;
		ChooseNextNode();
		currentPosition = transform.position;
		newPosition = nextNode.transform.position;
	}
	
	/** 
	 * Update is called once per frame.
	 */ 
	public void Update () {
		MoveToNode();
		
		if (NodeContact(transform.position, newPosition)) {
			currentNode = nextNode;
			transform.position = newPosition;
			EnterThrowState();		
		}
	}
	
	private void EnterThrowState() {
		gameObject.GetComponent<EnemyThrowBehavior>().enabled = true;
		gameObject.GetComponent<EnemyMove>().enabled = false;
	}
	
	/**
	 * Moves the enemy to the chosen node, if it is not already occupied.
	 */ 
	private void MoveToNode() {
		transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * moveSpeed);
	}
	
	/**
	 * Randomly chooses the next node.
	 */ 
	private void ChooseNextNode() {
		for (int i = 0; i < Random.Range(1, availableNodes.Length); i++) {
			nextNode = availableNodes[i];
		}
	}
	
	/**
	 * Finds available nodes in the scene.
	 */ 
	private void FindNodes() {		
		availableNodes = GameObject.FindGameObjectsWithTag("Node");
	}
	
	/**
	 * Determines if the enemy is close enough to the Node
	 * Prevents awkward movement behavior from float rounding issues
	 */ 
	private bool NodeContact(Vector3 transformPosition, Vector3 nodePosition) {
		bool contact = false;
		float accuracy = 0.02f;
		
		if ((transformPosition - nodePosition).sqrMagnitude <= (transformPosition * accuracy).sqrMagnitude) {
			contact = true;
		}
		return contact;
	}
}
