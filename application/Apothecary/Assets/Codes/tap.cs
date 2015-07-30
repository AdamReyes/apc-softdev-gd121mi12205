using UnityEngine;
using System.Collections;

public class tap : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
		// Look for all fingers
		for (int i = 0; i < Input.touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			
			// -- Tap: quick touch & release
			// ------------------------------------------------
			if (touch.phase == TouchPhase.Ended && touch.tapCount == 1)
			{
				// Touch are screens location. Convert to world
				Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);
				
				// Effect for feedback
				//SpecialEffectsScript.MakeExplosion((position));
			}
		}
	}
}
