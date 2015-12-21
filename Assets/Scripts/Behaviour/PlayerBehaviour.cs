﻿using System;
using System.Collections;
using UnityEngine;

public class PlayerBehaviour : EntityBehaviour {

    float protectDuration = 1;
    bool isProtected = false;


    public void KeepMoving() 
    {
        isMoving = true;
    }
    public void StopMoving() 
    {
        isMoving = false;
    }

    IEnumerator GetProtected(float blinkTime)
    {
        Renderer renderer = GetComponent<Renderer>();
        float timer = protectDuration;

        isProtected = true;

        while (timer > 0f) {
            timer -= Time.deltaTime;
            //toggle renderer
            renderer.enabled = !renderer.enabled;

            //wait for a bit
            yield return new WaitForSeconds(blinkTime);
        }
       
        renderer.enabled = true;
        isProtected = false;
    }


    protected override void ApplyDamage(float dmg) 
    {
        if (!isProtected) { 
            base.ApplyDamage(dmg);
            StartCoroutine(GetProtected(0.2f));
        }
    }

    protected override void Die()
    {
        Debug.Log("I are ded");
        //throw new NotImplementedException();
    }

}
