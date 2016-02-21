using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {
	static bool playing = false;

	void Awake()
	{
		if(playing)Destroy(this.gameObject);
	}

	void Start () {
		playing = true;
		GameObject.DontDestroyOnLoad(this);
	}
	

}
