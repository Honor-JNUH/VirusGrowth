using UnityEngine;
using System.Collections;

public abstract class ShooterBehaviour : MonoBehaviour {

    public GameObject bullet;
    public float fireSpeed;

    float lastFired;

    protected void ShootAt(Vector3 target)
    {
        Shoot(target - transform.position);
    }

    protected virtual void Shoot(Vector2 dir)
    {
        if (lastFired + fireSpeed < Time.time)
        {
            GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.FromToRotation(Vector2.right, Vector2.right));
            newBullet.SendMessage("Fire", dir);
            lastFired = Time.time;
        }
    }
    
}
