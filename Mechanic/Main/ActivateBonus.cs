using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ActivateBonus : MonoBehaviour {

	_Bonus bonus;
	public GlobalSlowBonus GSB;
	public HealBonus HB;
	public PointsBonus PB;

	public Text text;
	

	public int trigger;
	int counter = 0;

	public void passed()
	{
				counter++;
				if (counter >= trigger)
						Bonus ();
		}

	public void missed()
	{
			counter = 0;
	}

	int rand;

	void Bonus () {
		rand = Random.Range(1,4);
		switch(rand)
		{
			case 1:
			{
				bonus = GSB;
			bonus.activate();
			text.text = bonus.text;
			text.GetComponent<Animator> ().Play("Go");
			Debug.Log ("Slow");
			counter = 0;
				break;
			}
			case 2:
			{
				bonus = HB;
			bonus.activate();
			text.text = bonus.text;
			text.GetComponent<Animator> ().Play("Go");
			Debug.Log ("Heal");
			counter = 0;
				break;
			}
			case 3:
			{
				bonus = PB;
			bonus.activate();
			text.text = bonus.text;
			text.GetComponent<Animator> ().Play("Go");
			counter = 0;
				break;
			}
			default: 
			{
				Debug.Log ("Bad Bonus rand");
				break;
			}
		}
	}	
}
