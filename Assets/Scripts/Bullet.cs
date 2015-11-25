using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private float Bulletspeed;
	void Start (){
		Bulletspeed = 50f;
		Rigidbody2D.AddForce(transform.up * Bulletspeed);
	}

}
