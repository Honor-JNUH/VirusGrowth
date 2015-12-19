using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Vector3 dir;

    void Update () {
		float sero = Input.GetAxis ("Vertical");
		float garo = Input.GetAxis ("Horizontal");

        if (garo!= 0)
            Debug.Log(garo);

		if(sero != 0 || garo != 0) {
            dir = new Vector3(garo, sero, 0);
            
        }
	}


}
