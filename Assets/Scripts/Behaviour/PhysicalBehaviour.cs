using UnityEngine;
using System.Collections;

public class PhysicalBehaviour : MonoBehaviour {

    public float maxSpeed { get; protected set; }
    public float speed { get; protected set; }

    public Vector2 forward { get { return transform.TransformDirection(Vector2.right); } }
    public Rigidbody2D body { get { return GetComponent<Rigidbody2D>(); } }


    protected void LookAt(Vector2 target)
    {
        Vector2 dir = target - (Vector2)transform.position;
        body.MoveRotation(Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
    }
}
