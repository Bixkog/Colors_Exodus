using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class diff2 : MonoBehaviour {

	public Text text1;
	public Text text2;
	public Text text3;
	public AudioSource audio;
	Text lastText;
	public int last;
	
	void Start()
	{
		last = Options.instance.data.difficulty;
		switch (last) {
		case 1:
			text1.GetComponent<Animator> ().Play ("Grow");
			lastText = text1;
			break;
		case 2:
			text2.GetComponent<Animator> ().Play ("Grow");
			lastText = text2;
			break;
		case 3:
			text3.GetComponent<Animator> ().Play ("Grow");
			lastText = text3;
			break;
		}
	}
	
	
	public void changeDifficculty(float i)
	{
		if (Mathf.Approximately(i,1f) && last != 1) {
			changeEasy ();
			last = 1;
		} else if (Mathf.Approximately(i,0.5f) && last != 2) {
			changeMedium ();
			last = 2;
		} else if (Mathf.Approximately(i,0f) && last != 3) {
			changeHard ();
			last = 3;
		}
	}
	
	void changeEasy()
	{
		if(lastText!=null)
			lastText.GetComponent<Animator> ().Play("Shrink");
		lastText = text1;
		audio.Play ();
		lastText.GetComponent<Animator> ().Play("Grow");
	}
	
	void changeMedium()
	{
		if(lastText!=null)
			lastText.GetComponent<Animator> ().Play("Shrink");
		lastText = text2;
		audio.Play ();
		lastText.GetComponent<Animator> ().Play("Grow");
	}
	
	void changeHard()
	{
		if(lastText!=null)
			lastText.GetComponent<Animator> ().Play("Shrink");
		lastText = text3;
		audio.Play ();
		lastText.GetComponent<Animator> ().Play("Grow");
	}
}
