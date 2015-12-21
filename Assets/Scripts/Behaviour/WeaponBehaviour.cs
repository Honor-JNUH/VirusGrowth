﻿using UnityEngine;
using System.Collections;

public abstract class WeaponBehaviour : MonoBehaviour {

    public float defaultDamage;
    public String targetTag;

    float damage { get; protected set; }

    void Start () 
    {
        speed = defaultSpeed;
        damage = defaultDamage;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        HandleCollision(collision);
    }

    protected virtual void Hit(GameObject o) 
    {
        o.SendMessage("ApplyDamage", damage);
    }

    protected virtual void HandleCollision(Collision2D collision)
    {
        GameObject o = collision.gameObject;
        if (o.tag == targetTag)
            Hit(o);
    }

    
}