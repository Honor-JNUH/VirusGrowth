using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;

	void Move () {
		transform.Translate (transform.InverseTransformDirection (dir)* speed * Time.deltaTime);
		transform.rotation = Quaternion.FromToRotation (Vector3.right, dir);
	}
}
