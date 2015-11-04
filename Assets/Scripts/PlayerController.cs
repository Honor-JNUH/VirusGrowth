using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {



	void Start () {

	}
	// Update is called once per frame
	void Update () {
		float sero = Input.GetAxis ("Vertical");
		float garo = Input.GetAxis ("Horizontal");
		Vector3 dir = new Vector3 (garo, sero, 0);

	}
}
