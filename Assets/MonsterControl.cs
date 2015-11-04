using UnityEngine;
using System.Collections;

public class MonsterControl : MonoBehaviour {
	public Movement movement;
	public GameObject player;

	void Update () {
		movement.Move (Vector3.Normalize(player.transform.position - transform.position));

	}
}
