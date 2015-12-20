using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    PlayerBehaviour behaviour;

    void Update () {
		float sero = Input.GetAxis ("Vertical");
		float garo = Input.GetAxis ("Horizontal");

        if (garo!= 0)
            Debug.Log(garo);

		if(sero != 0 || garo != 0) {
            Vector3 dir = new Vector3(garo, sero, 0);
            behaviour.moveDirInput = dir;
            behaviour.isMoveInputActive = true;
        } else {
            behaviour.isMoveInputActive = false;
        }

	}


}
