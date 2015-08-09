using UnityEngine;
using System.Collections;

public class customer_interaction : MonoBehaviour {

	public GameObject money;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	void OnTriggerEnter2D (Collider2D hit) {

		if (hit.tag == "medicine") {

			Destroy(this.gameObject);
			Destroy(hit.gameObject);
			Instantiate(money, this.transform.position-new Vector3(0,0,0.7f), money.transform.rotation);

		}

	}
}
