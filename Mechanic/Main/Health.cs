using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	
	public int health = 10;
	public Text healthMesh;	

	public Text recordMesh;

	public GameObject GM;
	public GameObject BG;

	public AudioSource catched;
	public AudioSource missed;

	CurrentPoints CuP;
	CurrentColor CuC;
	CurrentSpeed CuS;

	void Start()
	{
		healthMesh.text = health.ToString();
		CuP = GM.GetComponent<CurrentPoints> ();
		CuC = GM.GetComponent<CurrentColor> ();
		CuS = GM.GetComponent<CurrentSpeed> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name=="Circle(Clone)"
		 &&other.gameObject.GetComponent<SetColor> ().COLOR 
		  		 == CuC.myColor)
		{
			other.gameObject.GetComponent<Click> ().destroyed();
			CuP.addPoints(CuS.start_speed);
			Destroy (other.gameObject);
			if(catched.enabled)catched.Play();
			BG.GetComponent<ActivateBonus> ().passed();
		}
		else
		{
			addHealth(-1);
			Destroy (other.gameObject);
			if(missed.enabled)missed.Play();
			BG.GetComponent<ActivateBonus> ().missed();
		}

	}

	public void addHealth(int i)
	{
				health += i;
				healthMesh.text = health.ToString ();
				if (health == 0)
						GM.GetComponent<PauseSystem> ().gameOver ();
		}
}
