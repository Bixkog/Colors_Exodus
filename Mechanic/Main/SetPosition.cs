using UnityEngine;
using System.Collections;

public class SetPosition : MonoBehaviour {
	
	public float min,max;
	Vector2 pos;
	
	void Awake () {
		pos.x = Random.Range (min, max);
		pos.y = Mathf.Sqrt ((Options.instance.distance_square - pos.x * pos.x)) - 8;
		this.transform.position = pos;
	}

}
