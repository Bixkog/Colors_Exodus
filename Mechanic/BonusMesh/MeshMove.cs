using UnityEngine;
using System.Collections;

public class MeshMove : MonoBehaviour {

	public float speed = 1.5f;
	public float duration = 2f;
	public Vector3 target;
	float timer = 0f;

	void OnEnable()
	{
		timer = 0f;
	}

	void Update()
	{
		if(timer < duration)
		{
			timer+=Time.deltaTime;
		}
		else
		{
			this.gameObject.SetActive(false);
		}
	}

	void FixedUpdate()
	{
		this.transform.position = Vector3.MoveTowards (transform.position, target, speed * Time.deltaTime);  
	}
}
