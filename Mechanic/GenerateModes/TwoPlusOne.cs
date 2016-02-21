using UnityEngine;
using System.Collections;

public class TwoPlusOne : _GenerateMode {

	public float timer1 = 0.5f;
	public float timer2 = 0.7f;
	public float timer3 = 1.5f;
	public float speedPercent;
	public GameObject circle;
	float counter = 0f;
	bool isWorking = false;
	bool second = false;
	bool third = false;

	CurrentSpeed CuS;
	void Start()
	{
		CuS = GameObject.Find ("GameMaster").GetComponent<CurrentSpeed> ();
	}
	void Update()
	{
		if(isWorking)
		{
			if(counter > timer1)
			{
				if(!second)
				{
					GameObject shot = Instantiate(circle) as GameObject;
					shot.GetComponent<Movement> ().speed += CuS.speed*speedPercent;
					shot.GetComponent<SetColor> ().preSetColor = Generate.last;
					second = true;
				}
				else if(counter > timer2)
				{
					if(!third)
					{
						GameObject shot2 = Instantiate(circle) as GameObject;
						shot2.GetComponent<Movement> ().speed += CuS.speed*speedPercent;
						shot2.GetComponent<SetColor> ().preSetColor = Generate.last;
						third = true;

					}
					else if(counter > timer3)
					{
						GameObject shot3 = Instantiate(circle) as GameObject;
						shot3.GetComponent<Movement> ().speed += CuS.speed*speedPercent;
						shot3.GetComponent<SetColor> ().preSetColor = Generate.last;
						isWorking = false;
					}
					else
						counter += Time.deltaTime;

				}
				else
					counter += Time.deltaTime;
			}
			else
				counter += Time.deltaTime;
		}
	}
	
	public override void turnOn()
	{
		isWorking = true;
		counter = 0f;
		second = false;
		third = false;
	}

	public override void turnOff()
	{
		isWorking = false;
	}
}
