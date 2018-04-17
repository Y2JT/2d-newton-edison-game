using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TommyController : MonoBehaviour {

	private TommyDisplay tommyDisplay;
	public float t_speed = 6.0f;
	private int t_score = 0;
	private int lights = 10;
	private Animator t_anim;

	public GameObject LightBulbOn;

	public AudioClip sound;
	public AudioClip space;
	AudioSource audio;

	void Start(){
		tommyDisplay = GetComponent<TommyDisplay> ();
		tommyDisplay.t_UpdateScoreText (t_score);
		tommyDisplay.UpdateLightsLeft (lights);
		t_anim = GetComponent<Animator> ();
		audio = GetComponent<AudioSource> ();
	}

	void Update(){
		Movement ();
		t_anim.SetFloat("moveX", Input.GetAxisRaw("Horizontal"));
		t_anim.SetFloat ("moveY", Input.GetAxisRaw ("Vertical"));
		if (t_score == 10) {
			Application.LoadLevel ("scene5_gamewin");
		}//end if
		if (Input.GetKeyDown (KeyCode.Space)) {
			audio.PlayOneShot (space);
		}//end if
	}

	//function that stores all movement
	void Movement(){
		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) {
			transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * t_speed * Time.deltaTime, 0f, 0f)); //rotates game object
		}//end if

		if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) {
			transform.Translate (new Vector3(0f, Input.GetAxisRaw("Vertical") * t_speed * Time.deltaTime, 0f));	//rotates game object
		}//end if
	}

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("lightbulb")){
			t_score++;
			lights--;
			tommyDisplay.t_UpdateScoreText (t_score);
			tommyDisplay.UpdateLightsLeft (lights);
			Destroy (hit.gameObject);
			Instantiate (LightBulbOn, transform.position, transform.rotation); //Spawn a "turned on light bulb" in place of "off" bulb
			audio.PlayOneShot (sound);
		}//end if
	}
}