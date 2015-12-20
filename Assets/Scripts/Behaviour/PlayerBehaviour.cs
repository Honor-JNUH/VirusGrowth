using UnityEngine;
using System.Collections;

public class PlayerBehaviour : EntityBehaviour {

    public Vector3 moveDirInput { get; set; }

    void Update()
    {
        Move(moveDirInput);
    }

    public void KeepMoving()
    {
        isMoving = true;
    }
    public void StopMoving()
    {
        isMoving = false;
    }
}
