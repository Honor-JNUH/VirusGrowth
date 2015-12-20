using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Ready : MonoBehaviour
{
    private string[] LevelName = {"", "level_1"};
    public Button PlayButton;

    public void HandleOnStateChange() {
    }

    public void BeginPlaying() {
        GameManager GM = GameManager.instance;
        Debug.Log("Let the game begin! Level: " + GM.level);

        GameManager.SetGameState(GameState.PLAY);
        Application.LoadLevel(LevelName[GM.level]);
    }


    void Start() {
        if (PlayButton != null) {
            PlayButton.onClick.AddListener(() => { BeginPlaying(); });
        }
    }

	void Awake() {
        GameManager.instance.OnStateChange += HandleOnStateChange;
	}
	
}
