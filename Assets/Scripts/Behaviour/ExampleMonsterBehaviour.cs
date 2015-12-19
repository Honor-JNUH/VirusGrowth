using UnityEngine;

public class ExampleMonsterBehaviour : EntityBehaviour {

    public GameObject player;

	void Update () {
        Follow(player.transform.position);
	}
}
