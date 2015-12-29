using UnityEngine;
using System.Collections;
using System;

public abstract class WeaponBehaviour : PhysicalBehaviour {

    public string targetTag;
    public float defaultDamage;

    public float damage { get; protected set; }

    void Awake () 
    {
        damage = defaultDamage;
    }

    protected virtual void Hit(GameObject o)
    {
        o.GetComponent<EntityBehaviour>().ApplyDamage(damage);
    }
}
