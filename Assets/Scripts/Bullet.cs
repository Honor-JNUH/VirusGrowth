using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private float Bulletspeed;
	void Start (){
		Bulletspeed = 50f;
		//GetComponent<Rigidbody2D>().(transform.up * Bulletspeed);
        //weird error
	}

}
