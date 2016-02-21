using UnityEngine;
using System.Collections;

public class MenuSystem : MonoBehaviour 
{
	public GameObject Menu;
	public GameObject Options2;
	public GameObject Highscores;
	public GameObject Upgrades;

	public GameObject lastOne;

	void Update()
	{
				if (Input.GetButtonDown("Escape") && lastOne != Menu) {
						goMenu ();
				}
		}

	public void goOptions()
	{ 
		lastOne.SetActive (false);
		lastOne = Options2;
		lastOne.SetActive (true);
	}

	public void goMenu()
	{ 
		lastOne.SetActive (false);
		lastOne = Menu;
		lastOne.SetActive (true);	
	}

	public void goHighscores()
	{
		lastOne.SetActive (false);
		lastOne = Highscores;
		lastOne.SetActive (true);
		
	}

	public void goUpgrades()
	{
		lastOne.SetActive (false);
		lastOne = Upgrades;
		lastOne.SetActive (true);	
	}


}
