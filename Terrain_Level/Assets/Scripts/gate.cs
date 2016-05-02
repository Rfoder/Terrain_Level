using UnityEngine;
using System.Collections;


public class gate : MonoBehaviour {



void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "player" && gate1.KeyCount > 0)		
			gate1.KeyCount--;
		Destroy (gameObject);
	}
}
