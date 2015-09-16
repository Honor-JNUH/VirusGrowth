using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour {

	public Transform joystick;
	public Vector3 axis;

	public float radiusLimit = 5;

	float radius;
	Vector3 defaultCenter;

	// Use this for initialization
	void Start () {
		radius = GetComponent<RectTransform> ().sizeDelta.y / 2 - radiusLimit;
		defaultCenter = joystick.position;
	
	}

	public void move() {
		Vector3 touchPos = Input.mousePosition;
		axis = (touchPos - defaultCenter).normalized;

		float fDistance = Vector3.Distance (touchPos, defaultCenter);
		if (fDistance > radius) {
			joystick.position = defaultCenter + axis * radius;
		} else {
			joystick.position = defaultCenter + axis * fDistance;
		}

	}

	public void end() {
		joystick.position = defaultCenter;
		axis = Vector3.zero;
	}
}
