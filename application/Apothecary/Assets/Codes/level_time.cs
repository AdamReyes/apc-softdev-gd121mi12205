using UnityEngine;
using System.Collections;

public class level_time : MonoBehaviour {
	public static float lvl_time;
	public static bool lvl_time_start;
	public static float lvl_duration;

	// Use this for initialization
	void Start () {
		lvl_time_start = true;
	}
	
	// Update is called once per frame
	void Update () {
		Level_Countdown ()
	}

	// Starts countdown for the level
	void Level_Countdown () {
		if (lvl_time_start == true) {
			lvl_time_start = false;
			yield WaitForSeconds (lvl_duration);
			lvl_time_start = false;
		}
	}
}
