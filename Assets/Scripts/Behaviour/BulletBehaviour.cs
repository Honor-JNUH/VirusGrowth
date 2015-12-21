using UnityEngine;
using System.Collections;

public abstract class BulletBehaviour : MonoBehaviour {

    public float maxSpeed { get; protected set; }
    public float speed { get; protected set; }
    public float damage { get; protected set; }

    void Fire() {

    }
}
