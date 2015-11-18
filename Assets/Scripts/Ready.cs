using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Ready : MonoBehaviour
{
    GameManager GM;
    private string[] LevelName = {"", "level_1"};
    public Button PlayButton;

    public void HandleOnStateChange() {
    }

    public void BeginPlaying() {
        Debug.Log("Let the game begin! Level: " + GM.Level);

        GM.SetGameState(GameState.PLAY);
        Application.LoadLevel(LevelName[GM.Level]);
    }

    void Awake() {
        GM = GameManager.instance;
        GM.OnStateChange += HandleOnStateChange;
    }

    void Start() {
        if (PlayButton != null) {
            PlayButton.onClick.AddListener(() => { BeginPlaying(); });
        }
    }

}
