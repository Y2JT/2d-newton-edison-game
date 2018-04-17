using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text timerText;
	public Slider timerSlider;
	public int timeForLevel = 30; 

	private CountdownTimer countdownTimer;

	void Start() {
		countdownTimer = GetComponent<CountdownTimer>();
		countdownTimer.ResetTimer(timeForLevel); 
	}
		
	void Update() {
		int secondsLeft = countdownTimer.GetSecondsRemaining();
		CheckGameOver(secondsLeft);
		UpdateTimerDisplay(secondsLeft);
		UpdateTimerSlider();
	}

	private void UpdateTimerSlider(){
		float proportionRemaining = countdownTimer.GetProportionTimeRemaining();
		timerSlider.value = proportionRemaining;
	}
		
	private void CheckGameOver(int secondsLeft){
		//game is over if seconds reach 0
		if(secondsLeft < 0){
			Application.LoadLevel("scene6_gameover"); 
		}//end if
	}
		
	private void UpdateTimerDisplay(int secondsLeft){
		string timerMessage = "Time left: " + secondsLeft;
		timerText.text = timerMessage;
	}
}