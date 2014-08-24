using UnityEngine;
using System.Collections;

public class HelicopterCollisionExplosion : MonoBehaviour {

	public ParticleSystem Explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		Explosion.transform.position = this.transform.position;
		Explosion.Play();
		Destroy (this.gameObject);
	}
}
