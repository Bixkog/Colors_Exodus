using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PauseSystem : MonoBehaviour {

	public GameObject generator;
	public GameObject[] circles;
	int speed;
	public GameObject[] buttons;

	public GameObject[] menuButtons;

	public GameObject record;
	public GameObject points;

	public Button pauseButton;

	bool isGameOver = false;
	bool isPaused = false;
	void Update()
	{
		if (Input.GetButtonDown ("Escape")) {
						if (!isGameOver && !isPaused)
								this.pauseGame ();
						else 
								Application.LoadLevel(0);
				}

	}



	public void pauseGame()
	{
		generator.SetActive (false);
		circles = GameObject.FindGameObjectsWithTag ("Circle");

		this.GetComponent<CurrentSpeed> ().enabled = false;

		foreach (GameObject circle in circles) {
						circle.GetComponent<Movement> ().speed = 0f;
				}

		foreach (GameObject mbutton in menuButtons) {
						mbutton.GetComponent<Animator> ().Play ("Begin");
				}
		isPaused = true;
		
	}

	public void unPauseGame()
	{


		this.GetComponent<CurrentSpeed> ().enabled = true;

		speed = this.GetComponent<CurrentSpeed> ().speed + 7;

		foreach (GameObject mbutton in menuButtons) {
				mbutton.GetComponent<Animator> ().Play ("End");
			}
		foreach (GameObject circle in circles) 
		{
			circle.GetComponent<Movement> ().speed = speed;
		}
		generator.SetActive (true);
		isPaused = false;
	}

	public void gameOver()
	{
		record.GetComponent<Animator> ().Play ("GameOver");
		points.GetComponent<Animator> ().Play ("GameOver");
		generator.SetActive (false);


		menuButtons [1].GetComponent<Animator> ().Play ("Begin");
		menuButtons [2].GetComponent<Animator> ().Play ("Begin");

		this.GetComponent<CurrentSpeed> ().enabled = false;
		circles = GameObject.FindGameObjectsWithTag ("Circle");
		foreach (GameObject circle in circles) {
			circle.GetComponent<Movement> ().speed = 0f;
		}

		pauseButton.interactable = false;

		if (Options.instance.data.ads) {
						if (Options.ads >= 2) {
								Options.ads = 0;
								print ("showing");
								GameObject.Find ("ads").GetComponent<GoogleMobileAdsDemoScript> ().Ads ();
						} else
								Options.ads ++;
				}

		isGameOver = true;
	}

}
