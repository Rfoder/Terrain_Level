using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float moveSpeed;


	public Transform[] patrolZones;

	private int currentPoint;
	// Use this for initialization
	void Start () {
	
		transform.position = patrolZones [0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
	 if (currentPoint >= patrolZones.Length) {
			currentPoint = 0;

		}
		if (transform.position == patrolZones [currentPoint].position) {

			currentPoint++;
		}

		transform.position = Vector3.MoveTowards (transform.position, patrolZones [currentPoint].position, moveSpeed * Time.deltaTime);

	}
}
