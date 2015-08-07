using UnityEngine;
using System.Collections;

public class individual_timer : MonoBehaviour {
	public static float individual_time;
	public static bool individual_time_start;

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

	}
}
