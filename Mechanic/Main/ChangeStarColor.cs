using UnityEngine;
using System.Collections;

public class ChangeStarColor : MonoBehaviour {

	public Renderer render;

	public void changeColor(int i)
	{
				if (i == 1)
						render.material.color = new Color (1f, 0f, 0f);
				if (i == 2)
						render.material.color = new Color (0f, 1f, 0f);

				if (i == 3)
						render.material.color = new Color (0f, 0f, 1f);
		}
}
