using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeVolumeText : MonoBehaviour {

	public Text text;
	public void changeText(float t)
	{
		text.text = Mathf.Round((t * 100)).ToString ();
	}
}
