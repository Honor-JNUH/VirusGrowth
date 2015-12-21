using UnityEngine;
using System.Collections;
using System;

public abstract class WeaponBehaviour : MonoBehaviour {

    public string targetTag;
    public float defaultDamage;

    public float damage { get; protected set; }

    void Awake () 
    {
        damage = defaultDamage;
    }

    protected virtual void Hit(GameObject o)
    {
        o.SendMessage("ApplyDamage", damage);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        HandleTrigger(collider);
    }

    void OnTriggerEnter2D(Collision2D collision)
    {
        HandleCollision(collision);
    }

    protected virtual void HandleCollision(Collision2D collision) { }
    protected virtual void HandleTrigger(Collider2D collider) { }
 
}
