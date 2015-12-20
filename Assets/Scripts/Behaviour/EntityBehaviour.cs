using UnityEngine;
using System.Collections;

public abstract class EntityBehaviour : MonoBehaviour {

    public float defaultSpeed;
    public float defaultHealth;

    protected float maxSpeed;
    protected float speed;
    protected float maxHealth;
    protected float health;
    protected bool isMoving;
    protected bool isDestroyable;

    void Awake () {
        maxSpeed = defaultSpeed;
        maxHealth = defaultHealth;
        health = maxHealth;
	}

    void Update () {
    }

    public void ApplyDamage(float dmg) {
        health -= dmg;
        if (health < 0) Die();
    }

    protected abstract void Die();

    public void Follow(Vector3 target)
    {
        Vector3 self = transform.position;
        Move(target - self);
    }

    public void Move(Vector3 dir)
    {
        if (isMoving && speed < maxSpeed)
            Accelerate();
        else if (!isMoving && speed > 0)
            Deccelerate();

        dir = dir.normalized;
        transform.Translate(transform.InverseTransformDirection(dir) * speed * Time.deltaTime);
        transform.rotation = Quaternion.FromToRotation(Vector3.right, dir);

        //Debug.Log(speed);
    }

    public void LookAt(Vector3 target)
    {
        Vector3 self = transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.right, target - self);
    }

    public void Accelerate()
    {
        speed = Mathf.Lerp(speed, maxSpeed, Time.time);
    }

    public void Deccelerate()
    {
        speed = Mathf.Lerp(speed, 0, Time.time);
    }

}
