using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class inventory2 : MonoBehaviour {

	public List<GameObject> Slots = new List<GameObject>();
	public List<med_data> datab = new List<med_data>();
	med_database database;
	public GameObject slots;
	int x = -140;
	int y = 55;

	// Use this for initialization
	void Start () {

		int slotAmount = 0;
		database = GameObject.FindGameObjectWithTag ("Med_database").GetComponent<med_database> (); // access to the database

		// the slots of the inventory
		for (int i = 1; i < 4; i++) //  columns
		{
			for (int k = 1; k < 7; k++) // rows
			{
				GameObject slot = (GameObject)Instantiate(slots); // copy of slots
				slot.GetComponent<slot_script>().slotNum = slotAmount;
				Slots.Add(slot);
				datab.Add(new med_data());
				slot.transform.parent =  this.gameObject.transform; // parenting to the other slots
				slot.name = "Slot" + i + "," + k; // name of slots
				slot.GetComponent<RectTransform>().localPosition = new Vector3(x,y,0); // position of the slot
				x = x + 55;
				if (k == 6) 
				{
					x = -139;
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
