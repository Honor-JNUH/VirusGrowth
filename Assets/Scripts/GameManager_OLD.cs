using UnityEngine;
using System.Collections;

public enum GameState_
{
	Ready,
	Play,
	End
}

public class GameManager_OLD : MonoBehaviour {

	public GameState_ Gs;
	public float Time;
	public GameObject FinishGUI;
	public GUIText Final_Count_Time;
	public GUIText Final_Count_HP;
	public GUIText Final_Count_Item;
	public GUIText Final_Score;
	public int Score;
	//tip,prefab
	void Start(){

	}
}
