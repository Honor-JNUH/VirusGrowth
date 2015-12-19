using UnityEngine;
using System.Collections;

public class EntityBehaviour : MonoBehaviour {

    public float defaultSpeed;

    protected float maxSpeed;
    protected float speed;

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

}
