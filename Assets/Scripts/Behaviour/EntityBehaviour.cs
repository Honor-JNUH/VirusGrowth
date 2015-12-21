using UnityEngine;
using System.Collections;

public abstract class EntityBehaviour : MonoBehaviour {

    public float defaultSpeed;
    public float defaultHealth;

    public float maxSpeed { get; protected set; }
    public float speed { get; protected set; }
    public float maxHealth { get; protected set; }
    public float health { get; protected set; }

    protected bool isMoving = false;
    protected bool isDestroyable = true;

    public Vector2 forward { get { return transform.TransformDirection(Vector2.right); } }

    void Awake () {
        maxSpeed = defaultSpeed;
        maxHealth = defaultHealth;
        health = maxHealth;
	}

    protected virtual void ApplyDamage(float dmg) {
        health -= dmg;
        Debug.Log("Ouch!! got " +dmg+ " dmg");
        if (health < 0) Die();
    }

    protected abstract void Die();

    protected void Follow(Vector2 target)
    {
        Vector2 self = transform.position;
        Move(target - self);
    }

    protected void Move(Vector2 dir)
    {
        if (isMoving && speed < maxSpeed)
            Accelerate();
        else if (!isMoving && speed > 0)
            Deccelerate();

        Rigidbody2D body = GetComponent<Rigidbody2D>();

        dir = dir.normalized;
        //transform.Translate(transform.InverseTransformDirection(dir) * speed * Time.deltaTime);
        //Quaternion.FromToRotation(Vector2.right, dir)
        body.MoveRotation(Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
        body.MovePosition(body.position + dir * speed * Time.deltaTime);
        
    }

    protected void LookAt(Vector2 target)
    {
        Vector2 dir = target - (Vector2) transform.position;
        GetComponent<Rigidbody2D>().MoveRotation(Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
    }

    protected void Accelerate()
    {
        speed = Mathf.Lerp(speed, maxSpeed, Time.time);
    }

    protected void Deccelerate()
    {
        speed = Mathf.Lerp(speed, 0, Time.time);
    }

}
