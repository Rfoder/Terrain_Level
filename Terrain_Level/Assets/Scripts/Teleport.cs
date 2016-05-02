using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public int tele;
	public Transform endLight;
	float disableTimer = 0;

	
	// Update is called once per frame
	void Update(){
		if (disableTimer > 0)
			disableTimer -= Time.deltaTime;

	}
	void OnTriggerEnter(Collider collider) {
	
		if (collider.gameObject.name == "player" && disableTimer <= 0) {
			endLight.light.enabled = true;
			foreach (Teleport tport in FindObjectsOfType <Teleport>()) {

				if (tport.tele == tele && tport != this) {
					tport.disableTimer = 15;
					Vector3 position = tport.gameObject.transform.position;
					position.y += 2;
					collider.gameObject.transform.position = position;

				}
			}

		}
	}
}
