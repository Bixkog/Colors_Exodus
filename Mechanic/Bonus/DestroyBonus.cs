using UnityEngine;
using System.Collections;

public class DestroyBonus : _Bonus {

	public GameObject wave;
	public float time = 1f;
	
	public override void activate ()
	{
		var destrWave = Instantiate(wave,new Vector2(Random.Range(-5,5),Random.Range(-5,5)),this.transform.rotation);
		GameObject.Destroy(destrWave,time);
	}
}
