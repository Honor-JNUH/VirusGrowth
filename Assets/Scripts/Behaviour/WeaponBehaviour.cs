using UnityEngine;
using System.Collections;

public abstract class WeaponBehaviour : MonoBehaviour {

    public string targetTag;
    public float defaultDamage;

    public float damage { get; protected set; }

    void Start () 
    {
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
            Debug.Log("fuck");
    }

    
}
