using UnityEngine;
using System.Collections;

public class med_data {

	public string medName;
	public int medID;
	public string medDesc;
	public Sprite medIcon;
	public GameObject medModel;
	public int medValue;
	public MedType medType;

	public enum MedType
	{
		Liquid,
		Tablet,
		Capsule,
		TopicalMedicine, // cream or ointments
		Suppositories,
		Drops,
		Inhalers,
		Injections,
		Implant, //patches
		Buccal, //sublingual tablet

	}
	public med_data(string name, int id, string desc, int value, MedType type)
	{
		medName = name;
		medID = id;
		medDesc = desc;
		medValue = value;
		medType = type;
		medIcon = Resources.Load<Sprite> ("" + name);
	} 
	public med_data()
	{
	}
}
