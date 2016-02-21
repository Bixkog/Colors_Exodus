using UnityEngine;
using System.Collections;

public class GenerateBonus : MonoBehaviour {

	public GameObject bonus;
	public float separator = 5f;

	float timer = 0f;

	void Update () 
	{
		if(timer < separator)
		{
			timer += Time.deltaTime;
		}
		else
		{
			timer = 0;
			Vector3 position = new Vector3(Random.Range(-6.5f,6.5f),Random.Range(-4f,6.5f),0);
			bonus.SetActive(true);
			bonus.transform.position = position;
		}
	}
}
