using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReadyState : SceneState
{
    private string[] LevelName = {"", "level_1"};
    public Button PlayButton;

    public void BeginPlaying() {
        Debug.Log("Let the game begin! Level: " + GM.level);

        GameManager.SetGameState(GameState.PLAY);
        SceneManager.LoadScene(LevelName[GM.level]);
    }

    void Start() {
        if (PlayButton != null) {
            PlayButton.onClick.AddListener(() => { BeginPlaying(); });
        }
    }
}
