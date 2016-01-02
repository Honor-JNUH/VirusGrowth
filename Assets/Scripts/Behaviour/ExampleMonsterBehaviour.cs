using System;
using UnityEngine;

public class ExampleMonsterBehaviour : EntityBehaviour {

    public float contactDamage;
    public GameObject player;
    

    void Start () 
    {
        isMoving = true;
    }

	void FixedUpdate () 
    {
        Vector2 playerPos = player.transform.position;
        Vector2 selfPos = transform.position;

        Follow(playerPos);
        /*
        if (Vector2.Distance(playerPos, selfPos) > 2) { 
            isMoving = true;
            Follow(playerPos);
        } else { 
            isMoving = true;
            LookAt(playerPos);
        }*/
    }

    protected override void Die() 
    {
        Destroy(gameObject);
        GameManager.AddScore(20);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        GameObject o = collision.gameObject;
        if (o.tag == "Player")
            o.GetComponent<EntityBehaviour>().ApplyDamage(contactDamage);
    }
}
