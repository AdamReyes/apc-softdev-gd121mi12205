using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class med_database : MonoBehaviour {

	public List<med_data> datab = new List<med_data>();
	
	// Use this for initialization
	void Start () {

		// add medicine data to this database
		datab.Add(new med_data ("Dpool", 0, "Treats cold", 1, med_data.MedType.Implant)); //Breathe Right
		datab.Add(new med_data ("Aman", 1, "Treats cough and cold", 1, med_data.MedType.Capsule)); //Fisherman's Friend
		datab.Add(new med_data ("CAmerica", 2, "Treats cold", 1, med_data.MedType.TopicalMedicine));	// Vicks BabyRub



	}
	

}
