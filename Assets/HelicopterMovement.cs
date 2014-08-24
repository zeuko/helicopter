using UnityEngine;
using System.Collections;

public class HelicopterMovement : MonoBehaviour {
	private const float rotationSpeed = 20.0f;
	private const float maxMovementSpeed = 30.0f;
	private const float maxAngle = 10.0f;
	private const float angleSpeed = 5.0f;
		
	private const float maxAltitudeSpeed = 20.0f;
	private const float altitudeSpeedIncrement = 5.0f;
	private float altitudeSpeed = 0.0f;
	
	private float angle = 0.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			this.transform.Rotate (Vector3.up, -rotationSpeed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.D)) {
			this.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.W)) {
			adjustAngle();
			Vector3 oldPosition = this.transform.position;
			this.transform.Translate(0.0f, maxMovementSpeed * Time.deltaTime, 0.0f);
			Vector3 newPosition = this.transform.position;
			newPosition.y = oldPosition.y;
			this.transform.position = newPosition;
		} else {
			resetAngle();
		}
		
		if (Input.GetKey(KeyCode.LeftShift)) {
			increaseAltitudeSpeed();
		} else {
			resetAltitudeSpeed();
		}
		adjustAltitude();
	}

	private void resetAngle() {
		if (angle < 0.0f) {
			float delta = angleSpeed * Time.deltaTime;
			angle += delta;
			this.transform.Rotate (delta, 0.0f, 0.0f);
		}
	}
	
	private void adjustAngle() {
		if (angle > -maxAngle) {
			float delta = -angleSpeed * Time.deltaTime;
			angle += delta;
			this.transform.Rotate (delta, 0.0f, 0.0f);
		}
	}

	private void increaseAltitudeSpeed() {
		if (altitudeSpeed < maxAltitudeSpeed) {
			float delta = altitudeSpeedIncrement * Time.deltaTime;
			altitudeSpeed += delta;
		}
	}
	
	private void decreaseAltitudeSpeed() {
		
	}
	
	private void resetAltitudeSpeed() {
		if (!Mathf.Approximately(0.0f, altitudeSpeed)) {
			float delta = altitudeSpeedIncrement * Time.deltaTime;
			if (altitudeSpeed > 0) {
				altitudeSpeed -= delta;
			} else {
				altitudeSpeed += delta;
			}
		}
	}
	
	private void adjustAltitude() {
		if (!Mathf.Approximately(0.0f, altitudeSpeed)) {
			Vector3 position = this.transform.position;
			position.y += altitudeSpeed * Time.deltaTime;
			this.transform.position = position;
		}
	}
}
