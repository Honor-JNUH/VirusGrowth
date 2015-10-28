using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed;

	void Start () {

	}
	// Update is called once per frame
	void Update () {
		float sero = Input.GetAxis ("Vertical");
		float garo = Input.GetAxis ("Horizontal");
		Vector3 dir = new Vector3 (garo, sero, 0);

		transform.Translate (dir * speed * Time.deltaTime);

	}
}
