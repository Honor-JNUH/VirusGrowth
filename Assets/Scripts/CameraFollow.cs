using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    Vector3 playerPos { get { return player.transform.position; } }
    Vector3 offset;
    Vector3 playerOffset;

    void Start()
    {
        offset = transform.position;
        playerOffset = playerPos;
    }

	// Update is called once per frame
	void Update () {
        transform.position = offset + playerPos - playerOffset;
	}
}
