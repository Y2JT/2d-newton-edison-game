using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour {

	public static Sounds Instance;

	public AudioClip Crunch;
	public AudioClip On;

	void Awake(){
		if (Instance != null) {
			Debug.LogError ("Multiple instances of Sounds!");
		}
		Instance = this;
	}

	public void MakeCrunchSound(){
		MakeSound (Crunch);
	}

	public void MakeOnSound(){
		MakeSound (On);
	}

	//play the sound
	private void MakeSound(AudioClip originalClip){
		AudioSource.PlayClipAtPoint (originalClip, transform.position);
	}
}