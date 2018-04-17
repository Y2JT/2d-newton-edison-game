using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitForPlayer : MonoBehaviour {

	private PlayerDisplay playerDisplay;
	public Text instructionsText;
	Animator anim;

	public AudioClip sound;
	AudioSource audio;

	public bool animation_bool;

	void Start(){
		anim = GetComponent<Animator> ();
		instructionsText.text = "Press Space To Play!";
		Time.timeScale = 0;
		playerDisplay = GetComponent<PlayerDisplay> ();
		audio = GetComponent<AudioSource> ();
	}

	void Update(){
		if (animation_bool == true) {
			anim.Play ("Sitting");
		}

		if (Input.GetButtonDown ("space")) {
			animation_bool = true;
		}

		if(Input.GetKeyDown(KeyCode.Space)){
			Time.timeScale = 1;
			Destroy(gameObject);
			Destroy (instructionsText);
		}
	}
}