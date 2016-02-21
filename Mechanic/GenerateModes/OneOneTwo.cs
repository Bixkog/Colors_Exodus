using UnityEngine;
using System.Collections;

public class OneOneTwo : _GenerateMode {

	public float[] timers;
	public GameObject circle;

	public int amount;
	public float speedPercent;
	int i = 0;
	float counter = 0f;
	bool isWorking = false;

	CurrentSpeed CuS;


	void Start()
	{
				CuS = GameObject.Find ("GameMaster").GetComponent<CurrentSpeed> ();
		}
	void Update()
	{
		if (isWorking) {
			if (counter > timers [i]) {
					i++;
					counter = 0;
					GameObject shot = Instantiate (circle) as GameObject;
					shot.GetComponent<Movement> ().speed += CuS.speed * speedPercent;
					shot.GetComponent<SetColor> ().preSetColor = Generate.last;
					if (i == amount)
							isWorking = false;
			}
			else
				counter += Time.deltaTime;
		} 
	}

	public override void turnOn()
	{
		isWorking = true;
		i = 0;
		counter = 0f;
	}

	public override void turnOff()
	{
	}
}
