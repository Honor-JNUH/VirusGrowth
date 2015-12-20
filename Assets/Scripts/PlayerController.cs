﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Vector3 dir;
    public PlayerBehaviour behaviour;

    void Start () {
        dir = new Vector3(0, 0, 0);
    }

    void Update () {
        //keyboard input
        float sero = Input.GetAxis ("Vertical");
		float garo = Input.GetAxis ("Horizontal");

        if (garo != 0 || sero != 0)
            dir = new Vector3(garo, sero, 0);

        if (dir.magnitude > 0.3)
            behaviour.KeepMoving();
        else
            behaviour.StopMoving();

        behaviour.Move(dir);
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
            Debug.Log("I've been hit!");
    }

}
