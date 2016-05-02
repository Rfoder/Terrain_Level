using UnityEngine;
using System.Collections;

public class keys : MonoBehaviour {


	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "player") {
			gate1.KeyCount+=2;
			Destroy (gameObject);
		}
	}


}
