using System;
using UnityEngine;

public class PlayerBehaviour : EntityBehaviour {

    public void KeepMoving() {
        isMoving = true;
    }
    public void StopMoving() {
        isMoving = false;
    }

    protected override void Die()
    {
        Debug.Log("I are ded");
        throw new NotImplementedException();
    }

}
