using UnityEngine;
using System.Collections;

public class BulletBehaviour : WeaponBehaviour {

    public float defaultSpeed;
    public float speed { get; protected set; }

    protected Vector2 dir;
    protected Rigidbody2D body { get { return GetComponent<Rigidbody2D>(); } }

    void Start () {
        speed = defaultSpeed;
    }

    void Update() {
        Move();
    }

    protected virtual void Move() 
    {
        //body.MovePosition(body.position + dir * speed * Time.deltaTime);
        body.MoveRotation(Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
    }

    protected virtual void Fire(Vector2 v)
    {
        dir = v;
        body.AddForce(v);
    }

}
