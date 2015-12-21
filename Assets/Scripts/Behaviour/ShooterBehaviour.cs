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
        if (lastFired + fireSpeed < Time.time)
        {
            GameObject newbullet = Instantiate(bullet, transform.position, new Vector2(0,0));
            newbullet.SendMessage("Fire", dir);
            lastFired = Time.time;
        }
    }
    
}
