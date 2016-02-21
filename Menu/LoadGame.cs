using UnityEngine;
using System.Collections;
using System;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class LoadGame : MonoBehaviour {

	
	public void Start()
	{
		if (Options.instance.data.difficulty == 2)
			Application.LoadLevel (3);
		else if (Options.instance.data.difficulty == 3)
			Application.LoadLevel (4);
		else 
			Application.LoadLevel (2);
	}
}
