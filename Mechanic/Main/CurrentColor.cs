using UnityEngine;
using System.Collections;

public class CurrentColor : MonoBehaviour {

	public int myColor = 0;
	public GameObject star;
	public void change_color(int i)
	{
			myColor = i;
	}
}
