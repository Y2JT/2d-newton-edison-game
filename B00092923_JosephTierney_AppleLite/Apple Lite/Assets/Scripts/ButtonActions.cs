using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour {

	public void BUTTON_LOAD_SCENE_WELCOME(){
		Application.LoadLevel("scene1_Welcome");
	}

	public void BUTTON_LOAD_SCENE_NEWTONPLAYING(){
		Application.LoadLevel("scene2_newtonplaying");
	}

	public void BUTTON_LOAD_SCENE_TOMMYPLAYING(){
		Application.LoadLevel("scene3_tommyplaying");
	}

	public void BUTTON_EXIT(){
		Application.Quit ();
	}
}