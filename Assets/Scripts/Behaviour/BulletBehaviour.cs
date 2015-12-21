using UnityEngine;
using System.Collections;

public abstract class BulletBehaviour : WeaponBehaviour {

    public float defaultSpeed;
    public float speed { get; protected set; }

    public Vector2 dir;

    void Update()
    {
        Move();
    }

    protected virtual void Move() 
    {
        body.MovePosition(body.position + transform.InverseTransformDirection(dir) * speed * Time.deltaTime);
    }

    protected virtual void Fire(Vector2 v)
    {
        dir = v;
        body.MoveRotation(Mathf.Atan2(dir.y, dir.x));
    }

}
