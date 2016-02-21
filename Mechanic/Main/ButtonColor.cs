using UnityEngine;
using System.Collections;

public class ButtonColor : MonoBehaviour {

	public int bColor=0;

	void Start()
	{
		this.gameObject.renderer.material.color = new Color(PlayerPrefs.GetFloat("r" + bColor),PlayerPrefs.GetFloat("g" + bColor),PlayerPrefs.GetFloat("b" + bColor));
	}
}
