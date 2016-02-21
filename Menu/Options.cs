using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;

public class Options : MonoBehaviour {

	public static Options instance;
	public Data data;
	public Data defaultData;
	public static int ads = 0;
	public GameObject[] OptionsSounds;
	AudioSource music;

	public float distance = 18f;
	public float distance_square = 520f;

	public GameObject MusicToggle;
	public GameObject SoundToggle;
	public GameObject AdsToggle;
	public GameObject SpeedSlider;
	public GameObject VolumeSlider;
	public GameObject DifficultyScrollbar;
	public GameObject ResetButton;

	void Awake()
	{
				instance = this;
				this.Load ();
		}

	void Start()
	{
		if(GameObject.Find("Audio")!=null)
			music = GameObject.Find ("Audio").GetComponent<AudioSource> ();
		if (Application.loadedLevelName == "Scene1" ||Application.loadedLevelName == "Scene2" ||Application.loadedLevelName == "Scene3")
			this.SetGame ();
		if (Application.loadedLevelName == "menu") {
						this.SetMenu ();
						this.SetOptions();
				}


	}

	void OnDestroy()
	{
		instance.Save ();
	}

	public void SetMenu()
	{
		music.volume = instance.data.volume;
		music.enabled = instance.data.music;
	}

	public void SetOptions()
	{

		MusicToggle.GetComponent<Toggle> ().isOn = instance.data.music;
		MusicToggle.GetComponent<AudioSource> ().enabled = true;

		SoundToggle.GetComponent<Toggle> ().isOn = instance.data.sound;
		SoundToggle.GetComponent<AudioSource> ().enabled = true;

		AdsToggle.GetComponent<Toggle> ().isOn = instance.data.ads;
		AdsToggle.GetComponent<AudioSource> ().enabled = true;

		if 		  (instance.data.difficulty == 1){
			DifficultyScrollbar.GetComponent<Scrollbar> ().value = 1f;
		} else if (instance.data.difficulty == 2) {
			DifficultyScrollbar.GetComponent<Scrollbar> ().value = 0.5f;
		} else if (instance.data.difficulty == 3) {
			DifficultyScrollbar.GetComponent<Scrollbar> ().value = 0.2f;
		}

		DifficultyScrollbar.GetComponent<AudioSource> ().enabled = true;

		SpeedSlider.GetComponent<Slider> ().value = instance.data.speed;
		    
		VolumeSlider.GetComponent<Slider> ().value = instance.data.volume;

		ResetButton.GetComponent<AudioSource> ().enabled = true;

		SetSoundOptions (); 
		music.volume = instance.data.volume;
	}

	public void SetGame()
	{
		AudioSource[] audio = GameObject.Find ("Star").GetComponents<AudioSource> () ;
		foreach (AudioSource i in audio) {
			i.volume = instance.data.volume;
			i.enabled = instance.data.sound;
		}
	}

	public void SetSoundOptions()
	{
		foreach (GameObject i in OptionsSounds) {
						i.GetComponent<AudioSource> ().enabled = instance.data.sound;
						i.GetComponent<AudioSource> ().volume = instance.data.volume;
				}
	}
	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/Data.dat");
		Data temp = new Data ();
		temp.speed = instance.data.speed;
		temp.sound = instance.data.sound;
		temp.music = instance.data.music;
		temp.ads = instance.data.ads;
		temp.difficulty = instance.data.difficulty;
		temp.volume = instance.data.volume;
		
		bf.Serialize (file, temp);
		file.Close ();
	}
	
	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/Data.dat")) {
						BinaryFormatter bf = new BinaryFormatter ();
						FileStream file = File.Open (Application.persistentDataPath + "/Data.dat", FileMode.Open);
						Data lastRecord = (Data)bf.Deserialize (file);

						instance.data.speed = lastRecord.speed;
						instance.data.sound = lastRecord.sound;
						instance.data.music = lastRecord.music;
						instance.data.ads = lastRecord.ads;
						instance.data.difficulty = lastRecord.difficulty;
						instance.data.volume = lastRecord.volume;

						file.Close ();
			
				} else {
						instance.data.speed = defaultData.speed;
						instance.data.sound = defaultData.sound;
						instance.data.music = defaultData.music;
						instance.data.ads = defaultData.ads;
						instance.data.difficulty = defaultData.difficulty;
						instance.data.volume = defaultData.volume;
				}
		}
		
		public void Reset()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/Data.dat");
		instance.data.speed = defaultData.speed;
		instance.Sound(defaultData.sound);
		instance.data.music = defaultData.music;
		instance.data.ads = defaultData.ads;
		instance.data.difficulty = defaultData.difficulty;
		instance.data.volume = defaultData.volume;
		SetOptions ();
		bf.Serialize (file, defaultData);
		file.Close ();
	}

	public void Sound(bool t)
	{
		if (instance != null) {
						instance.data.sound = t;
						instance.SetSoundOptions ();
				}

	}

	public void Music(bool t)
	{
		if(instance!=null)instance.data.music = t;
		if (!t && music!=null)
						music.enabled = false;
				else
						music.enabled = true;
	}

	public void Ads(bool t)
	{
		if(instance!=null)instance.data.ads = t;
	}

	public void Speed(float t)
	{
		if(instance!=null)instance.data.speed = (int)t;
	}

	public void Volume(float t)
	{
		if(instance!=null)
						instance.data.volume = t;
		if (music != null)
						music.volume = t;
	}

	public void Difficulty(float i)
	{
		if(i>0.66f)
		{
			if(instance!=null)instance.data.difficulty = 1;
		}
		else if(i>0.33f)
		{
			if(instance!=null)instance.data.difficulty = 2;
		}
		else
		{
			if(instance!=null)instance.data.difficulty = 3;
		}
	}

}


[Serializable]
public class Data
{
	public int speed;
	public bool sound;
	public bool music;
	public bool ads;
	public int difficulty;
	public float volume;
}
