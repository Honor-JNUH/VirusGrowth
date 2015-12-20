using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public PlayerBehaviour behaviour;

    void Update () {
        //keyboard input
		float sero = Input.GetAxis ("Vertical");
		float garo = Input.GetAxis ("Horizontal");

        Vector3 dir = new Vector3(garo, sero, 0);

        if (dir.magnitude > 0.2) {
            behaviour.KeepMoving();
        } else {
            behaviour.StopMoving();
        }

        behaviour.Move(dir);
	}


}
