using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class SetHardScore : MonoBehaviour {

	Record lastRecord;
	BinaryFormatter bf = new BinaryFormatter ();

	void Start()
	{
		FileStream file;
		try 
		{
			file = File.Open (Application.persistentDataPath + "/record3.dat", FileMode.Open);
			lastRecord = (Record)bf.Deserialize (file);
			file.Close ();
		} catch(FileNotFoundException e)
		{
			print (e);
		} finally
		{
			if (lastRecord != null)
				this.GetComponent<Text> ().text = lastRecord.setRecord.ToString ();
			else
				this.GetComponent<Text> ().text = "0";
		}
	}
}
