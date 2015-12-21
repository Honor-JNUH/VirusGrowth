using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public PlayerBehaviour behaviour;
    Vector2 dir;
    
    void Start () {
        dir = new Vector2(0, 0);
    }

    void Update () {
        //keyboard input movement
        float sero = Input.GetAxis ("Vertical");
		float garo = Input.GetAxis ("Horizontal");

        if (garo != 0 || sero != 0)
            dir = new Vector2(garo, sero);

        if (dir.magnitude > 0.1)
            behaviour.KeepMoving();
        else
            behaviour.StopMoving();

        behaviour.SendMessage("Move", dir);

        //shooting
        if (Input.GetKey("z")) {
            behaviour.shooter.SendMessage("Shoot", (Vector2) behaviour.forward);
            //Debug.Log();
        }
	}

}
