using UnityEngine;
using System.Collections;

public class EntityBehaviour : MonoBehaviour {

    public float defaultSpeed;

    protected float maxSpeed;
    protected float speed;
    protected bool isMoving;

    void Awake () {
        maxSpeed = defaultSpeed;
	}
	
    public void Move(Vector3 dir)
    {
        if (isMoving && speed < maxSpeed)
            Accelerate();
        if (!isMoving && speed > 0)
            Deccelerate();

        dir = dir.normalized;
        transform.Translate(transform.InverseTransformDirection(dir) * speed * Time.deltaTime);
        transform.rotation = Quaternion.FromToRotation(Vector3.right, dir);

        Debug.Log(speed);
    }

    public void Follow(Vector3 target)
    {
        Move(target - transform.position);
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
