using UnityEngine;
using System.Collections;

public class PadRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float rotationSpeed = 1500.0f;
		this.transform.Rotate (0.0f, 0.0f, rotationSpeed * Time.deltaTime);
	}
}
