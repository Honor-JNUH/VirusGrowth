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

    protected virtual void Shoot(Vector3 dir)
    {
        Quaternion rot = Quaternion.FromToRotation(Vector3.right, dir);
        Shoot(rot);
    }

    protected virtual void Shoot(Quaternion dir)
    {
        if (lastFired + fireSpeed < Time.time)
        {
            GameObject newbullet = Instantiate(bullet, transform.position, dir);
            newbullet.SendMessage("Fire");
            lastFired = Time.time;
        }
    }
    
}
