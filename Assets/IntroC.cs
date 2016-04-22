using UnityEngine;
using System.Collections;

public class IntroC : MonoBehaviour {

	private Vector3 moveVector;
	private Transform lookAt;
	private Vector3 startOffset;

	private float transition = 0.0f;
	private float animationDuration = 2.0f;
	private Vector3 animationOffset = new Vector3 (158,17,83);
	//private Vector3 animationOffset = new Vector3 (0,5,5);
	// Use this for initialization
	void Start () {
	//	lookAt = GameObject.FindGameObjectWithTag ("First_Persion_Controller").transform;
	//	startOffset = transform.position - lookAt.position;
	}
	
	// Update is called once per frame
	void Update () {

		//transform.position = lookAt.position + startOffset;
	 if (transition > 200.0f) {

			transform.position = moveVector;
		} else {
			transform.position = Vector3.Lerp(moveVector + animationOffset,moveVector,transition);
			transition += Time.deltaTime * 1 / animationDuration;
		}


	}
}
