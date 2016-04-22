using UnityEngine;
using System.Collections;

public class textenter : MonoBehaviour {

	private int count;
	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame


		void OnTriggerEnter(Collider other) {
			if (other.gameObject.tag ==  "Textonscreen") {
				
				other.gameObject.SetActive(false);
				count = count + 1;
		}
		
				if (other.gameObject.tag ==  "WhiteSmoke1") {
					
					other.gameObject.SetActive(true);
					count = count + 1;


			}
	}
	
}