using UnityEngine;
using System.Collections;

public class HelicopterMovement : AbstractMovement {
	protected override void resetAngle() {
		if (angle < 0.0f) {
			float delta = angleSpeed * Time.deltaTime;
			angle += delta;
			this.transform.Rotate (delta, 0.0f, 0.0f);
		}
	}
	
	protected override void adjustAngle() {
		if (angle > -maxAngle) {
			float delta = -angleSpeed * Time.deltaTime;
			angle += delta;
			this.transform.Rotate (delta, 0.0f, 0.0f);
		}
	}
}
