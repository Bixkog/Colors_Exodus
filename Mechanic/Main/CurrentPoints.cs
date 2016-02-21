using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CurrentPoints : MonoBehaviour {

	public int points;
	public float time = 0.25f;
	public Text text;
	void Start()
	{
		points = 0;
		text.text = points.ToString();
	}

	public void addPoints(int i)
	{
		points+=i;
		text.text = points.ToString();
	}
}