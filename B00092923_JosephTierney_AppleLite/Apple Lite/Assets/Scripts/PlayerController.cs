using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private PlayerDisplay playerDisplay;
	public float speed = 6.0f;
	private int score = 0;
	Animator anim;

	public AudioClip sound;
	public AudioClip space;
	AudioSource audio;

	void Start(){
		playerDisplay = GetComponent<PlayerDisplay> ();
		playerDisplay.UpdateScoreText (score);
		anim = GetComponent<Animator> ();
		audio = GetComponent<AudioSource> ();
	}

	void Update(){
		Movement ();
		if (score == 10) {
			score = 0; //reset score back to 0
			Application.LoadLevel ("scene4_level1win");
		}//end if

		if (Input.GetKeyDown (KeyCode.Space)) {
			audio.PlayOneShot (space);
		}//end if
	}

	//function that stores all movement
	void Movement(){
		anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));

		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);	//rotates game object
			transform.eulerAngles = new Vector2 (0, 0);
		}//end if

		if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);	//rotates game object
			transform.eulerAngles = new Vector2 (0, 180);
		}//end if
	}

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("apple")){
			score++;
			playerDisplay.UpdateScoreText (score);
			Destroy (hit.gameObject);
			audio.PlayOneShot (sound);
		}//end if
	}
}