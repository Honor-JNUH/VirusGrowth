using System;
using System.Collections;
using UnityEngine;

public class PlayerBehaviour : EntityBehaviour {

    public GameObject shooter;

    float protectDuration = 0.5f;
    bool isProtected = false;

    public void KeepMoving() {
        isMoving = true;
    }
    public void StopMoving() {
        isMoving = false;
    }

    IEnumerator GetProtected(float blinkTime)
    {
        Renderer renderer = GetComponent<Renderer>();
        float timer = protectDuration;

        isProtected = true;

        Debug.Log("Shield activated");

        while (timer > 0f) {
            timer -= Time.deltaTime;
            renderer.enabled = !renderer.enabled;
            
            yield return new WaitForSeconds(blinkTime);
        }
       
        renderer.enabled = true;
        isProtected = false;

        Debug.Log("Shield deactivated");
    }


    protected override void ApplyDamage(float dmg) 
    {
        if (!isProtected) { 
            base.ApplyDamage(dmg);
            StartCoroutine(GetProtected(0.1f));
        }
    }

    protected override void Die()
    {
        Debug.Log("I are ded");
        //throw new NotImplementedException();
    }

}
