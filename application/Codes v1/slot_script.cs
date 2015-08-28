using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class slot_script : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IDragHandler{

	public int slotNum;
	public med_data datab;
	Image medImage;
	inventory2 inventory;
	Text medAmount;

	// Use this for initialization
	void Start () {
		medAmount = gameObject.transform.GetChild (1).GetComponent<Text> ();
		inventory = GameObject.FindGameObjectWithTag("inventory").GetComponent<inventory2>();
		medImage = gameObject.transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () 
	{


		if(inventory.datab[slotNum].medName != null)
		{
			datab = inventory.datab[slotNum];
			medImage.enabled = true;
			medImage.sprite = inventory.datab[slotNum].medIcon;

			if(inventory.datab[slotNum].medType == med_data.MedType.Tablet) //Tablet
			{
				medAmount.enabled = true;
				medAmount.text = ""+inventory.datab[slotNum].medValue;
			}
			if(inventory.datab[slotNum].medType == med_data.MedType.Capsule)  //Capsule
			{
				medAmount.enabled = true;
				medAmount.text = ""+inventory.datab[slotNum].medValue;
			}
			if(inventory.datab[slotNum].medType == med_data.MedType.Liquid)  //Liquid
			{
				medAmount.enabled = true;
				medAmount.text = ""+inventory.datab[slotNum].medValue;
			}
			if(inventory.datab[slotNum].medType == med_data.MedType.TopicalMedicine) //Topical Medicine
			{
				medAmount.enabled = true;
				medAmount.text = ""+inventory.datab[slotNum].medValue;
			}
			if(inventory.datab[slotNum].medType == med_data.MedType.Implant)  //Implant
			{
				medAmount.enabled = true;
				medAmount.text = ""+inventory.datab[slotNum].medValue;
			}
			if(inventory.datab[slotNum].medType == med_data.MedType.Drops) //Drops
			{
				medAmount.enabled = true;
				medAmount.text = ""+inventory.datab[slotNum].medValue;
			}
		}
		else 
		{
			medImage.enabled = false;
		}
	
	}
	public void OnPointerDown(PointerEventData data) // clicking
	{
		if (inventory.datab [slotNum].medName == null && inventory.draggingItem) {
			inventory.datab [slotNum] = inventory.thedragItem;
			inventory.closeDraggedItem ();
		} 
		else if (inventory.draggingItem && inventory.datab[slotNum].medName != null)
		{
			inventory.datab[inventory.slotIndex] = inventory.datab[slotNum];
			inventory.datab[slotNum] = inventory.thedragItem;
			inventory.closeDraggedItem();
		}
		//Debug.Log (transform.name);
	}

	public void OnPointerEnter(PointerEventData data) //hovering
	{
		if (inventory.datab [slotNum].medName != null && inventory.draggedItem) 
		{
			//Debug.Log(inventory.datab[slotNum].medDesc);
			inventory.showTooltip(inventory.Slots[slotNum].GetComponent<RectTransform>().localPosition, inventory.datab[slotNum]);
		}
	}

	public void OnPointerExit(PointerEventData data) //not hovering
	{
		if (inventory.datab [slotNum].medName != null)
		inventory.closeTooltip();
	}

	public void OnDrag(PointerEventData data) //drag
	{
		if (inventory.datab [slotNum].medName != null) 
		{
			inventory.showDraggedItem (inventory.datab [slotNum], slotNum);
			inventory.datab[slotNum] = new med_data();
			//Debug.Log ("Dragging");
			medAmount.enabled = false;
		}
	
	}

}
