using UnityEngine;
using System.Collections;

public class Birds : MonoBehaviour {
	public AudioSource source;
	public AudioClip Clip;
	private bool isPlayed;

	public void Awake(){
		source = GetComponent<AudioSource>();
		isPlayed = false;
	}
	// Use this for initialization
	public void OnTriggerEnter(Collider other) {
	if (!isPlayed) {
			source.Play();
			isPlayed = true;
		}
	}
	
	// Update is called once per frame
public void OnTrigge(Collider other) {
		if (source.isPlaying);{
			source.Stop ();
		}
	}
	
	}

