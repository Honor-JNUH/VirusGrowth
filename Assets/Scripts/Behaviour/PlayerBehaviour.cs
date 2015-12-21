using System;
using UnityEngine;

public class PlayerBehaviour : EntityBehaviour {

    float invincivilityTime = 1;
    float lastHit;

    bool isInvincible { get {return Time.time < lastHit + invincivilityTime;} set {} }

    void Update()
    {
        if (isInvincible)
        {
            StartCoroutine(Blink());
        }
    }

    public void KeepMoving() 
    {
        isMoving = true;
    }
    public void StopMoving() 
    {
        isMoving = false;
    }

    IEneumerator Blink()
    {
        yield return new WaitForSeconds(0.2f);
    }

    protected override void ApplyDamage(float dmg) 
    {
        if (!isInvincible) { 
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
