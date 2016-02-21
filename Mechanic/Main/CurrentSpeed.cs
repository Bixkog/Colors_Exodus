using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CurrentSpeed : MonoBehaviour {

	[HideInInspector] public int speed;
	[HideInInspector] public int start_speed;
	public int acceleration = 1;
	public float duration = 10f;
	public Text Gtext;
	public int maxSpeed;

	GameObject[] circles;

	float timer = 0f;
	// Use this for initialization
	void Start () 
	{
		timer = 0f;
		speed = Options.instance.data.speed;
		start_speed = speed;
		Gtext.text = speed.ToString();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(timer > duration)
		{
			timer = 0f;
			addSpeed(acceleration);
		}
		else
		{
			timer +=Time.deltaTime;
		}
	}

	public void addSpeed(int i)
	{
		if (speed + i <= maxSpeed) {
						speed += i;
						Gtext.text = speed.ToString ();
						circles = GameObject.FindGameObjectsWithTag ("Circle");
						foreach (GameObject circle in circles) {
								circle.GetComponent<Movement> ().speed = speed + 7;
						}
				}
	}

	public void decreaseSpeed(int i)
	{
		speed -=i;
		Gtext.text = speed.ToString();
		circles = GameObject.FindGameObjectsWithTag ("Circle");
		foreach (GameObject circle in circles) {
			circle.GetComponent<Movement> ().speed = speed + 7;
		}
	}
}
