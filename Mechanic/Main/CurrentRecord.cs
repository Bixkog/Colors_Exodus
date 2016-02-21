using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;


public class CurrentRecord : MonoBehaviour {

	public int globalRecord;
	public CurrentPoints CuP;
	public Text Gtext;
	// Use this for initialization
	void Start () {
		Load ();
		Gtext.text = globalRecord.ToString();
	}

	void Update()
	{
		if(globalRecord < CuP.points) 
			globalRecord = CuP.points; 

		Gtext.text = globalRecord.ToString();
	}

	void OnDestroy()
	{
		Save ();
	}
	public void Save()
	{
		Record record = new Record ();
		record.setRecord = globalRecord;

		BinaryFormatter bf = new BinaryFormatter ();

		if (Application.loadedLevelName == "Scene1") {
			FileStream file;
			file = File.Create (Application.persistentDataPath + "/record1.dat");
			if (file != null)
					bf.Serialize (file, record);
			file.Close ();
				}
		if(Application.loadedLevelName == "Scene2"){
			FileStream file;
			file = File.Create (Application.persistentDataPath + "/record2.dat");
			if (file != null)
				bf.Serialize (file, record);
			file.Close ();

		}
		if(Application.loadedLevelName == "Scene3"){
			FileStream file;
			file = File.Create (Application.persistentDataPath + "/record3.dat");
			if (file != null)
				bf.Serialize (file, record);
			file.Close ();

		}


		
	}

	public void Load()
	{

			BinaryFormatter bf = new BinaryFormatter ();
			Record lastRecord;

			if (File.Exists (Application.persistentDataPath + "/record1.dat") && Application.loadedLevelName == "Scene1")
			{
				FileStream file;
				file = File.Open (Application.persistentDataPath + "/record1.dat", FileMode.Open);
				lastRecord = (Record)bf.Deserialize (file);
				globalRecord = lastRecord.setRecord;
				file.Close ();
			}
			else if (File.Exists (Application.persistentDataPath + "/record2.dat") && Application.loadedLevelName == "Scene2"){
				FileStream file;
				file = File.Open (Application.persistentDataPath + "/record2.dat", FileMode.Open);
				lastRecord = (Record)bf.Deserialize (file);
				globalRecord = lastRecord.setRecord;
				file.Close ();
			}
			else if (File.Exists (Application.persistentDataPath + "/record3.dat") && Application.loadedLevelName == "Scene3"){
				FileStream file;
				file = File.Open (Application.persistentDataPath + "/record3.dat", FileMode.Open);
				lastRecord = (Record)bf.Deserialize (file);
				globalRecord = lastRecord.setRecord;
				file.Close ();
			}
		else
			globalRecord = 0;


				 
	}
	

}

 [Serializable]
class Record
{
	public int setRecord;
}