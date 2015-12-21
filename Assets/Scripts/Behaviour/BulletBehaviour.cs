using UnityEngine;
using System.Collections;

public abstract class BulletBehaviour : MonoBehaviour {

    public float defaultSpeed;
    public float defaultDamage;
    public String targetTag;

    public float speed { get; protected set; }
    public float damage { get; protected set; }

    protected string targetTag;

    void Start () 
    {
        speed = defaultSpeed;
        damage = defaultDamage;
    }

    protected virtual void Fire() 
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }

    protected virtual void Hit(GameObject o) 
    {
        if (o.tag == targetTag)
            o.SendMessage("ApplyDamage", damage);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Hit(collision.gameObject);
    }
}
