using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Ready : MonoBehaviour
{
    GameManager GM;
    private string[] LevelName = {"", "level_1"};

    public Button PlayButton;


    public void HandleOnStateChange() {
        Debug.Log("Let the game begin!");
        Application.LoadLevel(LevelName[GM.Level]);
    }

    public void BeginPlaying() {
        GM.SetGameState(GameState.PLAY);
    }

    void Awake() {
        GM = GameManager.Instance;
        GM.OnStateChange += HandleOnStateChange;
    }

    void Start() {
        if (PlayButton != null) {
            PlayButton.onClick.AddListener(() => { BeginPlaying(); });
        }
    }

}
