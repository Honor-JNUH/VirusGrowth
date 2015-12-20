using System;
using UnityEngine;

public class ExampleMonsterBehaviour : EntityBehaviour {

    public GameObject player;

    void Start () {
        isMoving = true;
    }

	void Update () {
        Vector3 playerPos = player.transform.position;
        Vector3 selfPos = transform.position;

        if (Vector3.Distance(playerPos, selfPos) > 2) { 
            isMoving = true;
            Follow(playerPos);
        } else { 
            isMoving = false;
            HeadTowards(playerPos);
        }
    }

    protected override void Die()
    {
        throw new NotImplementedException();
    }
}
