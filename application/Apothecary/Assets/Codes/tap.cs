using UnityEngine;
using System.Collections;

public class tap : MonoBehaviour {

	Vector3 move;

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
			if (touch.phase == TouchPhase.Began && touch.tapCount == 1)
			{
				// Touch are screens location. Convert to world
				move = new Vector3 (touch.position.x,touch.position.y,0);
				this.transform.position = new Vector3 (move.x, move.y, move.z);
				// Effect for feedback
				//SpecialEffectsScript.MakeExplosion((position));

			}
		}
	}
}
