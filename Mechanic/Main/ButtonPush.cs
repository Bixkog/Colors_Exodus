using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ButtonPush : MonoBehaviour {

	public GameObject GM;
	CurrentColor CuC;
	CurrentButton CuB;
	public int index;

	void Start()
	{
				CuC = GM.GetComponent<CurrentColor> ();
				CuB = GM.GetComponent<CurrentButton> ();
		}

	public void OnPointerDown(PointerEventData eventData)
	{
				CuC.change_color (index);
				CuB.change_button_sprite (index);
		}
}
