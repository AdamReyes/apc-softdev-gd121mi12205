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

	void OnPointerDown (PointerEventData eventData) {

		transform.Translate (10, 0, 0);

	}
}
