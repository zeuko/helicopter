using UnityEngine;
using System.Collections;

public abstract class AbstractMovement : MonoBehaviour {
	protected const float rotationSpeed = 20.0f;
	protected const float maxMovementSpeed = 30.0f;
	protected const float maxAngle = 10.0f;
	protected const float angleSpeed = 5.0f;
	
	protected float angle = 0.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftBracket)) {
			this.transform.Rotate (0.0f, -rotationSpeed * Time.deltaTime, 0.0f);
		} else if (Input.GetKey (KeyCode.RightBracket)) {
			this.transform.Rotate(0.0f, rotationSpeed * Time.deltaTime, 0.0f);
		} 
		if (Input.GetKey(KeyCode.UpArrow)) {
			adjustAngle();
			this.transform.Translate(0.0f, maxMovementSpeed * Time.deltaTime, 0.0f);
		} else {
			resetAngle();
		}
	}
	
	protected abstract void resetAngle();
	
	protected abstract void adjustAngle();
}