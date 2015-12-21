using UnityEngine;
using System.Collections;

public class ShooterBehaviour : MonoBehaviour {

    public GameObject bullet;
    public float fireSpeed;
    float lastFired;

    public Vector2 forward { get { return transform.TransformDirection(Vector2.right); } }

    protected void ShootAt(Vector3 target)
    {
        Shoot(target - transform.position);
    }

    protected virtual void Shoot(Vector2 dir)
    {
        if (lastFired + fireSpeed < Time.time)
        {
            Quaternion rot = Quaternion.FromToRotation(Vector2.right, Vector2.right);
            GameObject newBullet = (GameObject) Instantiate(bullet, transform.position, rot);
            newBullet.SendMessage("Fire", dir);
            lastFired = Time.time;
        }
    }
    
}
