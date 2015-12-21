using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Vector3 dir;
    public PlayerBehaviour behaviour;

    void Start () {
        dir = new Vector2(0, 0);
    }

    void Update () {
        //keyboard input movement
        float sero = Input.GetAxis ("Vertical");
		float garo = Input.GetAxis ("Horizontal");

        if (garo != 0 || sero != 0)
            dir = new Vector2(garo, sero);

        if (dir.magnitude > 0.3)
            behaviour.KeepMoving();
        else
            behaviour.StopMoving();

        behaviour.Move(dir);

        //shooting

	}

}
