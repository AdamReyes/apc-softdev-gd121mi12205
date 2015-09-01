using UnityEngine;
using System.Collections;

public class individual_timer : MonoBehaviour {
	public static float individual_time;
	public static bool individual_time_start;
	public static float individual_duration;

	// Use this for initialization
	void Start () {
		individual_time_start = true;
	}
	
	// Update is called once per frame
	void Update () {
		Countdown ();
	}

	// Starts Countdown for customers
	void Countdown () {
		if (individual_time_start == true) {
			individual_time_start = false;
			yield WaitForSeconds (individual_duration);
			individual_time_start = true;
		}
	}
}
