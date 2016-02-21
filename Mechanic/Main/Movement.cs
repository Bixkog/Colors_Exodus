using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 5f;
	public Transform target;
	
	void FixedUpdate()
	{
		transform.position = Vector3.MoveTowards (transform.position, target.transform.position, speed * Time.deltaTime);  
	}
}
