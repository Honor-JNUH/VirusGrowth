using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public PlayerBehaviour behaviour;

    void Update () {
		float sero = Input.GetAxis ("Vertical");
		float garo = Input.GetAxis ("Horizontal");

        Vector3 dir = new Vector3(garo, sero, 0);

        //Debug.Log("Input magnitude:" + dir.magnitude);

        if (dir.magnitude > 0.2) {
            behaviour.moveDirInput = dir;
            behaviour.KeepMoving();
        } else {
            behaviour.StopMoving();
        }

	}


}
