using UnityEngine;
using System.Collections;

public class HealBonus : _Bonus {


	public override void activate()
	{
		GameObject.Find("Star").GetComponent<Health> ().addHealth(Random.Range(1,4));
	}
}
