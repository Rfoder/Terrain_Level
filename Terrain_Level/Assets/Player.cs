using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private int count;
	public GUIText countText;
	public GUIText winText;

	void Start()
	{
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void OnAwake(){

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag ==  "flint") {

			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();


		}
		
		if (other.gameObject.tag ==  "WhiteSmoke1") {
			
			other.gameObject.SetActive(true);
			count = count + 1;
		}
	}
	void SetCountText(){
		countText.text = "Count: " + count.ToString ();
		if (count >= 3) {
			winText.text = "YOU WIN!";
		}
	}

}
