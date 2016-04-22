using UnityEngine;
using System.Collections;

public class text : MonoBehaviour {



	// Use this for initialization
	void Start () {
	 
		gameObject.SetActive (false);

	
	}

	void OnTriggerEnter () {
		 
		gameObject.SetActive (true);
	}

	void OnTriggerExit () {
		gameObject.SetActive (false);
		Destroy (gameObject);
	}

}
