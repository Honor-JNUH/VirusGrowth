using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;

	public void Move (Vector3 dir) {
		transform.Translate (transform.InverseTransformDirection (dir) * speed * Time.deltaTime);
		transform.rotation = Quaternion.FromToRotation (Vector3.right, dir);
	}
}
