using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Changetext : MonoBehaviour {

	public Text text;

	public void changeText(float i)
	{
		text.text = i.ToString();
	}
}
