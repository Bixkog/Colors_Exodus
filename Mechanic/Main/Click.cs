using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
	
	public ParticleSystem particles;	

	public void destroyed()
	{
		var shot  = Instantiate(particles,transform.position,transform.rotation)as ParticleSystem;
		shot.startColor = this.gameObject.renderer.material.color;
		shot.randomSeed = 0;
		Object.Destroy(shot.gameObject,0.5f);
		Destroy (this.gameObject);
	}
	
}