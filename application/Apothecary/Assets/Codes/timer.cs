using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {
	public static float timers = 60; 
	public static bool timeStarted = false;
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	
	// Update is called once per frame
	void Start(){
		timeStarted = true;
	}
	void Update () {
		if (timeStarted == true) {
			timers -= Time.deltaTime;
		}
		if (timers <= 0.0) {
			timeStarted = false;
			Application.LoadLevel("gameisover");
			ResetTimer();
		}
	}
	void OnGUI() {
		int minutes = Mathf.FloorToInt(timers / 60F);
		int seconds = Mathf.FloorToInt(timers - minutes * 60);
		
		string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
		guiStyle.fontSize = 40; //change the font size

		GUI.Label(new Rect(450,80,150,200), niceTime, guiStyle);
	}
	void ResetTimer() {
		timers = 60;
	}


}
