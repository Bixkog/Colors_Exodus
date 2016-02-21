using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {


	_GenerateMode mode;
	public TwoPlusOne twoplusone;
	public OneOneTwo oneonetwo;
	public float pauseDuration;
	public static int last = 0;
	float duration = 0f;
	float separator = 0f;


	int rand;

	void Update()
	{
		if(duration<=0f)
		{
			if(mode!=null)mode.turnOff ();
			if(separator<=0f)
			{
				rand = Random.Range(1,4);
				switch(rand)
				{
					//wybieraj tutaj
				case 1:
					mode = twoplusone;
					mode.turnOn();
					duration = mode.duration;
					separator = mode.separator;
					break;
				case 2:
					mode = oneonetwo;
					mode.turnOn();
					duration = mode.duration;
					separator = mode.separator;
					break;
				case 3:
					duration = pauseDuration;
					break;
				default:
					Debug.Log("nie generuje " + rand.ToString(), gameObject);
					break;
				}
			} else {
				separator-=Time.deltaTime;
			}
		} else {
			duration-=Time.deltaTime;
		}
	}


}

