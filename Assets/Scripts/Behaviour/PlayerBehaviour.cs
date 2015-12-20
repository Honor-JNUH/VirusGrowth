using System;
using UnityEngine;

public class PlayerBehaviour : EntityBehaviour {

    public void KeepMoving() {
        isMoving = true;
    }
    public void StopMoving() {
        isMoving = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
            Debug.Log("I've been hit!");
    }

    protected override void Die()
    {
        throw new NotImplementedException();
    }

}
