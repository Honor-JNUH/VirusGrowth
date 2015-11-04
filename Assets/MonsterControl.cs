using UnityEngine;
using System.Collections;

public class MonsterControl : MonoBehaviour {
	public Movement movement;
	public GameObject player;

	void Update () {
		movement.Move (player.transform.position - transform.position);

		/* 플레이어와 적의 거리에 따라 적의 이동 속도가 달라짐. (멀리 있으면 속도 빨라지고 가까이 있으면 속도 느려짐) */
	}
}
