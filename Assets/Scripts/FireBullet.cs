using UnityEngine;
using System.Collections;

public class FireBullet : MonoBehaviour {
	public GameObject Bullet;
	public GameObject player;

	public void Attack (){
		GameObject currentBullet;
		//currentBullet = Instantiate (Bullet, player.transform.position, Quaternion.identity);
		//transform.rotation = Quaternion.identity;
	}
	
	void Start () {
		Attack ();
	}
	
	// Update is called once per frame

}
