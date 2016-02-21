using UnityEngine;
using System.Collections;

public class SetColor : MonoBehaviour {
	
	[HideInInspector]public int COLOR;
	[HideInInspector]public int preSetColor=0;
	int rand;


	void Start() {
		if (preSetColor == 0) {
			rand = Random.Range (1, 4);
			COLOR = rand;
			if (rand == 1)
				{
					COLOR = 1;
					gameObject.renderer.material.color = new Color (1f, 0f, 0f);
					Generate.last = COLOR;
				}
			else if (rand == 2)
				{
					COLOR = 2;
					gameObject.renderer.material.color = new Color (0f, 1f, 0f);
					Generate.last = COLOR;
				}
			else if (rand == 3)
				{
					COLOR = 3;
					gameObject.renderer.material.color = new Color (0f, 0f, 1f);
					Generate.last = COLOR;
				}
		} else if (preSetColor == 1) {
			rand = Random.Range (1, 3);
			if (rand == 1)
				{
					COLOR = 2;
					gameObject.renderer.material.color = new Color (0f, 1f, 0f);
					Generate.last = COLOR;
				}
			else
				{
					COLOR = 3;
					gameObject.renderer.material.color = new Color (0f, 0f, 1f);
					Generate.last = COLOR;
				}
		} else if (preSetColor == 2) {
			rand = Random.Range (1, 3);
			if (rand == 1)
				{
					COLOR = 1;
					gameObject.renderer.material.color = new Color (1f, 0f, 0f);
					Generate.last = COLOR;
				}
			else
				{
					COLOR = 3;
					gameObject.renderer.material.color = new Color (0f, 0f, 1f);
					Generate.last = COLOR;
				}
		}else if (preSetColor == 3) {
			rand = Random.Range (1, 3);
			if (rand == 1)
				{
					COLOR = 2;
					gameObject.renderer.material.color = new Color (0f, 1f, 0f);
					Generate.last = COLOR;
				}
			else
				{
					COLOR = 1;
					gameObject.renderer.material.color = new Color (1f, 0f, 0f);
					Generate.last = COLOR;
				}
		}
				
	}


}
