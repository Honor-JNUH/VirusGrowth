using UnityEngine;
using System.Collections;

public class EntityBehaviour : MonoBehaviour {

    public Movement movement;
    public float defaultSpeed;

    float maxSpeed;
    float speed;

    void Start () {
        maxSpeed = defaultSpeed;
	}
	
	void Update () {
	
	}

    public void Move(Vector3 dir)
    {
        Vector3.Normalize(dir);
        transform.Translate(transform.InverseTransformDirection(dir) * speed * Time.deltaTime);
        transform.rotation = Quaternion.FromToRotation(Vector3.right, dir);
    }

    public void Follow(Vector3 target)
    {
        Move(target - transform.position);
    }

    public void Accelerate(float maxTime = 1)
    {
        if (speed < maxSpeed)
            speed += (2 * maxSpeed / maxTime) * Time.deltaTime;
    }

    public void Deccelerate(float maxTime = 1)
    {
        if (speed > 0)
            speed -= (2 * maxSpeed / maxTime) * Time.deltaTime;
        else if (speed < 0)
            speed = 0;
    }
}
