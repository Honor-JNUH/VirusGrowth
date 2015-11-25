using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public Movement movement;	
	Vector3 dir;

	// Update is called once per frame
	void Update () {
		float sero = Input.GetAxis ("Vertical");
		float garo = Input.GetAxis ("Horizontal");

		if(sero != 0 || garo != 0) {
			dir = new Vector3 (garo, sero, 0);
			movement.Move (dir);

			/* 
			 * 방향키 두 개를 누르고 있다가 하나를 먼저 떼면 수직 방향으로 바뀌어버림
			 * 왼쪽 키를 누를 때 박스가 뒤집힘
			 */
		}
	}


}
