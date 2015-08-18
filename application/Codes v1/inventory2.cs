using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class inventory2 : MonoBehaviour {


	public List<GameObject> Slots = new List<GameObject>();
	public List<med_data> datab = new List<med_data>();
	med_database database;
	public GameObject slots;
	int x = -150;//-450;
	int y = 55;
	public GameObject toolTip;
	public GameObject draggedItem;
	public bool draggingItem = false;
	public med_data thedragItem; //dragged Item
	public int slotIndex;

	void Update() 
	{
		if (draggingItem) // Drag
		{
			Vector3 post = (Input.mousePosition - GameObject.FindGameObjectWithTag("Canvas").GetComponent<RectTransform>().localPosition);
			draggedItem.GetComponent<RectTransform>().localPosition = new Vector3(post.x +15, post.y - 15, post.z);
		}

	}

	public void showTooltip(Vector3 toolPosition, med_data datab) 
	{
		toolTip.SetActive (true);
		toolTip.GetComponent<RectTransform> ().localPosition = new Vector3 (toolPosition.x, toolPosition.y + 50, toolPosition.z);
		toolTip.transform.GetChild (0).GetComponent<Text> ().text = datab.medName; 
		toolTip.transform.GetChild (2).GetComponent<Text> ().text = datab.medDesc; 

	}

	public void closeTooltip()
	{
		toolTip.SetActive (false);
	}


	public void showDraggedItem(med_data datab, int slotnumber) //drag
	{
		slotIndex = slotnumber;
		closeTooltip ();
		draggedItem.SetActive (true);
		thedragItem = datab;
		draggingItem = true;
		draggedItem.GetComponent<Image>().sprite = datab.medIcon;
	}

	public void closeDraggedItem() // drag
	{
		draggedItem.SetActive (false);
		draggingItem = false;
	}




	// Use this for initialization
	void Start () {

		int slotAmount = 0;
		database = GameObject.FindGameObjectWithTag ("Med_database").GetComponent<med_database> (); // access to the database

		// the slots of the inventory
		for (int i = 1; i < 7; i++) //  columns
		{
			for (int k = 1; k < 6; k++) // rows
			{
				GameObject slot = (GameObject)Instantiate(slots); // copy of slots
				slot.GetComponent<slot_script>().slotNum = slotAmount;
				Slots.Add(slot);
				datab.Add(new med_data());
				slot.transform.parent =  this.gameObject.transform; // parenting to the other slots
				slot.name = "Slot" + i + "," + k; // name of slots
				slot.GetComponent<RectTransform>().localPosition = new Vector3(x,y,0); // position of the slot
				x = x + 55;
				if (k == 5) 
				{
					x = -149; //-449;
					y = y - 55;
				}
				slotAmount++;
			}
		}

		//add items to the UI
		addMed (0);
		addMed (1);
		addMed (2);
		//Debug.Log (datab [0].medName); // shows the first medicine


	
	}

	void addMed(int id) 
	{

		for (int i = 0; i < database.datab.Count; i++) 
		{
		if (database.datab[i].medID == id) // the item's id
				//Debug.Log(database.datab.Count);
			{

				med_data datas = database.datab[i]; //creating new data to the item
				//Debug.Log(datas.medName);
				addMedEmtptySlot(datas);
				//datab.Add (datas);
				break;
			}
		}
	}

	void addMedEmtptySlot(med_data datas)
	{
		for (int i = 0; i < datab.Count; i++) 
		{
			if (datab[i].medName ==  null)
			{
				datab[i] = datas;
				break;
			}
		}

	}
}
