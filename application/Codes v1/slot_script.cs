using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class slot_script : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler{

	public int slotNum;
	public med_data datab;
	Image medImage;
	inventory2 inventory;
	// Use this for initialization
	void Start () {
		inventory = GameObject.FindGameObjectWithTag("inventory").GetComponent<inventory2>();
		medImage = gameObject.transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

		if(inventory.datab[slotNum].medName != null)
		{
			datab = inventory.datab[slotNum];
			medImage.enabled = true;
			medImage.sprite = inventory.datab[slotNum].medIcon;
		}
		else 
		{
			medImage.enabled = false;
		}
	
	}
	public void OnPointerDown(PointerEventData data) 
	{
		Debug.Log (transform.name);
	}

	public void OnPointerEnter(PointerEventData data)
	{
		if (inventory.datab [slotNum].medName != null) 
		{
			Debug.Log(inventory.datab[slotNum].medDesc);

		}
	}

}
