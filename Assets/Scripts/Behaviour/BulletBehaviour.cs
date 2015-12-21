using UnityEngine;
using System.Collections;

public class BulletBehaviour : WeaponBehaviour {

    public float defaultSpeed;
    public float speed { get; protected set; }

    public Vector2 forward { get { return transform.TransformDirection(Vector2.right); }  }
    protected Rigidbody2D body { get { return GetComponent<Rigidbody2D>(); } }

    void Awake () {
        damage = defaultDamage;
        speed = defaultSpeed;
    }

    void Update() {
        Move();
    }

    protected virtual void Move() 
    {
        body.MovePosition(body.position + forward * speed * Time.deltaTime);
    }

    protected virtual void Fire(Vector2 d)
    {
        body.MoveRotation(Mathf.Atan2(d.y, d.x) * Mathf.Rad2Deg);
        //body.AddForce(forward * 1000000);
    }

    protected override void HandleTrigger(Collider2D collider)
    {
        GameObject o = collider.gameObject;
        if (o.tag == targetTag)
            Hit(o);
            Destroy(gameObject);
    }

}
