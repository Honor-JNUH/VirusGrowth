using UnityEngine;
using System.Collections;

public abstract class BulletBehaviour : WeaponBehaviour {

    public float defaultSpeed;
    public float speed { get; protected set; }


    protected virtual void Fire(Vector3 dir) 
    {
        //transform.Translate(transform.forward * speed * Time.deltaTime);
    }
    
}
