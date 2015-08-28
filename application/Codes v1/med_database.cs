using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class med_database : MonoBehaviour {

	public List<med_data> datab = new List<med_data>();
	
	// Use this for initialization
	void Start () {

		// add medicine data to this database

		
		// Ace Inhibitors
		datab.Add(new med_data ("Enalapril 10mg tab", 0, "Treatment of hypertension & heart failure", 3, med_data.MedType.Tablet)); //Breathe Right
		datab.Add(new med_data ("Enalapril Maleate", 1, "Treatment of hypertension & heart failure", 1, med_data.MedType.Tablet)); //Fisherman's Friend
		datab.Add(new med_data ("Enalapril tab 20mg", 2, "Treatment of hypertension & heart failure", 1, med_data.MedType.Tablet));	// Vicks BabyRub

		//Allergies
		datab.Add(new med_data ("Loratidine tab", 3, "Cures allergies", 1, med_data.MedType.Tablet));
		datab.Add(new med_data ("Desloratadine", 4, "Cures allergies", 1, med_data.MedType.Liquid));

		//Amoebic and Parasitic infection
		datab.Add(new med_data ("Mebendazole syrup", 6, "Treatment of nematode infestations, including roundworm, whipworm, threadworm and hookworm.", 1, med_data.MedType.Liquid));
		datab.Add(new med_data ("Metronidazole tab", 7, "treatment of nematode infestations, including roundworm, whipworm, threadworm and hookworm.", 1, med_data.MedType.Tablet));
		datab.Add(new med_data ("Pyrantel Pamoate syrup", 8, "used to treat intestinal worm infections such as pinworm, roundworm, and hookworm.", 1, med_data.MedType.Liquid));

		//Antibiotic
		datab.Add(new med_data ("Cloxacillin syrup", 9, "Treatment of infections due to staphylococcus resistant to benzyl penicillin, ", 1, med_data.MedType.Liquid));

		//Bandages
		datab.Add(new med_data ("Mediplast Bantam Strips", 10, "Bandages small wound/s", 1, med_data.MedType.Implant));

		//Cold and Flu
		datab.Add(new med_data ("COLDZEP tab", 11, "Treats runny nose, nasal congestion, post-nasal drip, itchy & watery eyes, fever.", 1, med_data.MedType.Tablet));

		//Cough and Cold remedies
		datab.Add(new med_data ("Bromhexine HCL syrup", 12, "Common cold, flu & resp tract infection associated w/ excessive & tenacious bronchial secretions.", 1, med_data.MedType.Liquid));
		datab.Add(new med_data ("Carbocisteine drops", 13, "Treats All types of cough, chronic & acute bronchitis, cough induced sinusitis, bronchial asthma", 1, med_data.MedType.Drops));

		//Diarrhea
		datab.Add(new med_data ("LOPERAMIDE cap", 14, " Cures diarrhea", 1, med_data.MedType.Capsule));

		//Eczema
		datab.Add(new med_data ("Betamethasone cream", 15, "For topical administration for the treatment of skin disorders.", 1, med_data.MedType.TopicalMedicine));

		//Fever and muscle pain
		datab.Add(new med_data ("Tramadol cap", 16, "Moderate to severe pain", 1, med_data.MedType.Capsule));

		//Hypertension
		datab.Add(new med_data ("Amlodipine Besilate", 17, "Treatment of hypertension and prophylaxis of anginae", 1, med_data.MedType.Tablet));

		//Muscle Pain
		datab.Add(new med_data ("Pau Liniment", 18, "Cures muscle pain", 1, med_data.MedType.TopicalMedicine));

		//Nauseau, vomiting
		datab.Add(new med_data ("BETAVERT tab", 19, "Treatment of Meniere's disease, syndrome characterized by attacks of vertigo, sensorineural deafness, dizziness.", 1, med_data.MedType.Tablet));

		//Pimples and Boils
		datab.Add(new med_data ("FUSIDIC ACID CREAM", 20, "Cures pimples and boils", 1, med_data.MedType.TopicalMedicine));
		datab.Add(new med_data ("Mupirocin", 21, "Treats primary skin infections and secondary infections", 1, med_data.MedType.TopicalMedicine));

		//Tuberculosis
		datab.Add(new med_data ("Loratidine tab", 22, "Treatment of pulmonary & extrapulmonary TB", 1, med_data.MedType.Tablet));
		datab.Add(new med_data ("Isoniazid syrup", 23, "Prevention & treatment of pulmonary & extrapulmonary TB.", 1, med_data.MedType.Liquid));

		// Vitamins
		datab.Add(new med_data ("LEMONCEE PLUS syrup", 24, "For the treatment and prevention of Vitamin and Zinc deficiencies", 1, med_data.MedType.Liquid));
		datab.Add(new med_data ("LEMON-CEE", 25, "Prevention & treatment of Vitamin C deficiency", 1, med_data.MedType.Tablet));
		datab.Add(new med_data ("FERRO-B cap", 26, "For the iron-deficiency conditions esp iron defecciency anemia", 1, med_data.MedType.Capsule));

		//Pain, Fever
		datab.Add(new med_data ("ENERLAX cap", 27, "Relief of runny nose, nasal congestion, post-nasal drip, itchy & watery eyes,", 1, med_data.MedType.Capsule));
		datab.Add(new med_data ("Ibuprofen Syrup", 28, "Relief of fuctional menstrual pain eg dysmenorrhea, cramps, headache , muscular aches,", 1, med_data.MedType.Liquid));
		datab.Add(new med_data ("DOLCETAL tab", 29, "For management of moderate to severe pain.", 1, med_data.MedType.Tablet));
		datab.Add(new med_data ("FEVERGAN tab", 30, "Relief of fever, minor aches & pains.", 1, med_data.MedType.Tablet));



	}
	

}
