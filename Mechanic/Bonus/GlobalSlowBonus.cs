using UnityEngine;
using System.Collections;

public class GlobalSlowBonus : _Bonus 
{
	public override void activate()
	{
		GameObject.Find("GameMaster").GetComponent<CurrentSpeed> ().decreaseSpeed(1);
	}
}
