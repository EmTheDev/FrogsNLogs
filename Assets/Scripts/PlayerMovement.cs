using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Animator playerAnimator;
	private float moveHorizontal;
	private float moveVertical;
	private Vector3 movement;

	// Use this for initialization
	void Start () {
		
		//Gather the Animator component from the Player GameObject
		playerAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Gather input from the keyboard
		moveHorizontal = Input.GetAxisRaw ("Horizontal");
		moveVertical = Input.GetAxisRaw ("Vertical");

		movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
	}

	void FixedUpdate() {

		//if the player's movement vector does not equal zero...
		if (movement != Vector3.zero) {
			//...then play the jump animation.
			playerAnimator.SetFloat ("Speed", 3f);
		} else {
			//Otherwise, don't play the jump animation.
			playerAnimator.SetFloat ("Speed", 0f);
		}
	}
}
