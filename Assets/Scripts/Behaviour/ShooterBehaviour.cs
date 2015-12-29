using UnityEngine;
using System.Collections;

public class ShooterBehaviour : PhysicalBehaviour {

    public GameObject bullet;
    public float fireSpeed;
    float lastFired;

    protected void ShootAt(Vector3 target)
    {
        LookAt(target);
        Shoot();
    }

    protected virtual void Shoot()
    {
        if (lastFired + fireSpeed < Time.time)
        {
            GameObject newBullet = (GameObject) Instantiate(bullet, transform.position, transform.rotation);
            newBullet.SendMessage("Fire", forward);
            lastFired = Time.time;
        }
    }
    
}
