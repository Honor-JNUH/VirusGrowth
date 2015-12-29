using UnityEngine;
using System.Collections;

public class ShooterBehaviour : PhysicalBehaviour {

    public GameObject bullet;
    public float fireSpeed;

    float lastFired;

    public void ShootAt(Vector3 target)
    {
        LookAt(target);
        Shoot();
    }

    public virtual void Shoot()
    {
        if (lastFired + fireSpeed < Time.time)
        {
            GameObject newBullet = (GameObject) Instantiate(bullet, transform.position, transform.rotation);
            newBullet.GetComponent<BulletBehaviour>().Fire(forward);
            lastFired = Time.time;
        }
    }
    
}
