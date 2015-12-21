using System;
using UnityEngine;

public class PlayerBehaviour : EntityBehaviour {

    float invincivilityTime = 1;
    float lastHit;

    public void KeepMoving() 
    {
        isMoving = true;
    }
    public void StopMoving() 
    {
        isMoving = false;
    }

    public override void ApplyDamage(float dmg) 
    {
        if (Time.time > lastHit + invincivilityTime) { 
            base.ApplyDamage(dmg);
            lastHit = Time.time;
        }
    }

    protected override void Die()
    {
        Debug.Log("I are ded");
        //throw new NotImplementedException();
    }

}
