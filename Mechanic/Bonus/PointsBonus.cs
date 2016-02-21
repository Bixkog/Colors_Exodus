using UnityEngine;
using System.Collections;

public class PointsBonus : _Bonus {

	public int points;
	

	public override void activate ()
	{
		GameObject.Find("GameMaster").GetComponent<CurrentPoints>().addPoints(points);
	}
}
