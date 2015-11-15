using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Ready : MonoBehaviour
{
    GameManager GM;
    private string[] LevelName = {"", "level_1"};

    public Button PlayButton;


    public void HandleOnStateChange()
    {
        Debug.Log("Let the game begin!");
        Application.LoadLevel(LevelName[GM.Level]);
    }

    public void BeginPlaying()
    {
        //start game scene
        GM.SetGameState(GameState.PLAY);
        Debug.Log(GM.gameState);
    }

    void Awake()
    {
        GM = GameManager.Instance;
        GM.OnStateChange += HandleOnStateChange;
    }

    void Start()
    {
        PlayButton.onClick.AddListener(() => { BeginPlaying(); });
    }

}
