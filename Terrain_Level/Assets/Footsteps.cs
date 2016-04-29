using UnityEngine;
using System.Collections;
//RF
public class Footsteps : MonoBehaviour {

	CharacterController cc;

	// Use this for initialization
	void Start () {
	
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
	

			if (cc.isGrounded == true && cc.velocity.magnitude > 2f && audio.isPlaying == false) {
			//audio.volume = Random.Range (0.8f, 1);
			//audio.pitch = Random.Range (0.8f, 1.1f);
			audio.Play ();
		}
	}
}
