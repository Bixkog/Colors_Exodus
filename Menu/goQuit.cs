using UnityEngine;
using System.Collections;

public class goQuit : MonoBehaviour {

	void Update()
	{
		if(Input.GetButtonDown("Escape"))
		{
			Application.Quit();
		}
	}
	
	public void use()
	{
		Application.Quit();
	}
}
