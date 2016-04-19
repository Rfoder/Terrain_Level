using UnityEngine;
using System.Collections;

public class headbobs : MonoBehaviour {

	public CharacterController playerController;
	public Animation anim; 
	private bool isMoving;
	
	private bool left;
	private bool right;
	
	void CameraAnimations(){
		if(playerController.isGrounded == true){
			if(isMoving == true){
				if(left == true){
					if(!anim.isPlaying){
						anim.Play("walkL");
						left = false;
						right = true;
					}
				}
				if(right == true){
					if(!anim.isPlaying){
						anim.Play("walkL 1");
						right = false;
						left = true;
					}
				}
			}                      
		}
	}
	
	
	void Start () { 
		left = true;
		right = false;
	}
	
	
	void Update () {
		float inputX = Input.GetAxis("Horizontal"); 
		float inputY = Input.GetAxis("Vertical");
		
		if(inputX  != 0 || inputY != 0){
			isMoving = true;       
		}
		else if(inputX == 0 && inputY == 0){
			isMoving = false;      
		}
		
		CameraAnimations();
		
	}
}
