using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TommyDisplay : MonoBehaviour {

	public Text t_scoreText;
	public Text lightsLeft;

	public void t_UpdateScoreText(int t_newScore){
		string t_scoreMessage = "Lights On: " + t_newScore;
		t_scoreText.text = t_scoreMessage;
	}

	public void UpdateLightsLeft(int newLights){
		string lightsMessage = "Lights Left: " + newLights;
		lightsLeft.text = lightsMessage;
	}
}