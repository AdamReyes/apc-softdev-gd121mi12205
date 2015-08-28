using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class screen_button_R : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {

		Camera.main.transform.position = screen_control.current;

		if (screen_control.center == true) {
			screen_control.right = true;
			screen_control.center = false;
		}

		if (screen_control.left == true) {
			screen_control.center = true;
			screen_control.left = false;
		}

	}
}
