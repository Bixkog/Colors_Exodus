using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CurrentButton : MonoBehaviour {

	public GameObject PanelRed;
	public GameObject PanelGreen;
	public GameObject PanelBlue;

	GameObject currentButton;
	public int cB;
	public void change_button_sprite(int i)
	{
		if (cB != i) {
						if (currentButton != null)
								currentButton.GetComponent<Animator> ().Play ("Pull");
						if (i == 1) {
								currentButton = PanelRed;
								cB = 1;
						} else if (i == 2) {
								currentButton = PanelGreen;
								cB = 2;
						} else if (i == 3) {
								currentButton = PanelBlue;
								cB = 3;
						}

						currentButton.GetComponent<Animator> ().Play ("Push");
				}
	}
}
