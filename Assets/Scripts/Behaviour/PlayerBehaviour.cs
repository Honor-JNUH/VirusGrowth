using UnityEngine;
using System.Collections;

public class PlayerBehaviour : EntityBehaviour {

    public bool isMoveInputActive;
    public bool isShootInputActive;

    void Update()
    {

        if(isMoveInputActive) {
           speed = Mathf.Lerp(speed, maxSpeed, Time.time);
        } else {
           speed = Mathf.Lerp(speed, 0, Time.time);
        }

    }

}
