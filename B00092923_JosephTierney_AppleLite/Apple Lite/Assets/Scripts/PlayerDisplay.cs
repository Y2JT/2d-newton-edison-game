using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour {

	public Text scoreText;

	public void UpdateScoreText(int newScore){
		string scoreMessage = "" + newScore;
		scoreText.text = scoreMessage;
	}
}