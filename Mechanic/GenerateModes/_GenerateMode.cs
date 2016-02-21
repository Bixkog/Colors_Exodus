using UnityEngine;
using System.Collections;

public abstract class _GenerateMode : MonoBehaviour {

	public abstract void turnOn();
	public abstract void turnOff();
	public float duration;
	public float separator;
}
