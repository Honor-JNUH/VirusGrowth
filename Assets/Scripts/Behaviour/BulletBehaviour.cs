using UnityEngine;
using System.Collections;

public class BulletBehaviour : WeaponBehaviour {

    void Awake () {
        damage = defaultDamage;
        speed = defaultSpeed;
    }

    void FixedUpdate() {
        Move();
    }

    protected virtual void Move() 
    {
        body.MovePosition(body.position + forward * speed * Time.deltaTime);
    }

    public virtual void Fire(Vector2 d)
    {
        body.MoveRotation(Mathf.Atan2(d.y, d.x) * Mathf.Rad2Deg);
        //body.AddForce(forward * 1000000);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject o = collider.gameObject;
        if (o.tag == targetTag) { 
            Hit(o);
            Destroy(gameObject);
        }
    }

}
