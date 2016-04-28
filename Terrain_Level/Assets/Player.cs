using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	public GUIText countText;
	public Transform firelight;
	public Transform firelight1;
	public Transform firelight2;
	public Transform endLight;
	public GUIText winText;
	public float seconds = 3.0f;

	private Vector3 reSpawn;
	private int count;


	void Start()
	{

		count = 0;
		SetCountText ();
		winText.text = "";
		reSpawn = transform.position;
	}

	void OnAwake(){
	//	firelight.light.enabled = false;
	}

	//void OnCollisionEnter(Collision other){
		//if (other.transform.tag =="endLight"){
		//	transform.position = reSpawn;
		//}
	//}




	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "flint") {

			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
			

		}

		
		if (other.gameObject.tag == "WhiteSmoke1") {

			other.gameObject.particleSystem.Play (true);

			//other.gameObject.SetActive(true);

			//count = count + 1;
			SetCountText ();

		}
		if (other.gameObject.tag == "firelight") {
			//other.gameObject.light.enabled = true;
			firelight.light.enabled = true;

			//count = count + 1;
		}
		if (other.gameObject.tag == "firelight1") {
			//other.gameObject.light.enabled = true;
			firelight1.light.enabled = true;
			
			//count = count + 1;
		}
		if (other.gameObject.tag == "firelight2") {
			//other.gameObject.light.enabled = true;
			firelight2.light.enabled = true;
			
			//count = count + 1;
		}
		//if (other.gameObject.tag == "endLight") {
			//other.gameObject.light.enabled = true;
			//endLight.light.enabled = true;
			
			//count = count + 1;
		//}
		
	}
	 

	void SetCountText(){

		countText.text = "Bonfire: " + count.ToString ();

		if (count >= 3) {
			endLight.light.enabled = true;
			winText.text = "YOU WIN!";

			//seconds -= Time.deltaTime;
			//if(seconds <= 0.0f)		

			transform.position = reSpawn;
			}
	
		}
	void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag == "Enemy")
		{
			Die();
			
		}
		
	}
	void Die(){
		transform.position = reSpawn;
	}
	}



