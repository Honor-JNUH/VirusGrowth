using UnityEngine;
using System.Collections;

public class TouchSpot : MonoBehaviour {

    bool registered = false;

    void Start()
    {
        Debug.Log("pfff");
        registered = true;
    }

    void Update()
    {
        Debug.Log(registered);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(!registered)
        {

        }
    }
}
