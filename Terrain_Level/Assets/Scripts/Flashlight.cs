using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	private bool lightOn =false;


	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.F))
			lightOn = !lightOn;

		if (lightOn)
			light.enabled = true;
		else if (!lightOn)
			light.enabled = false;
		}
	}
