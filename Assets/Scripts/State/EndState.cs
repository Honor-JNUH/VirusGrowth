using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class EndState : SceneState
{
    public Button NextButton;
    public Text ScoreMessage;

    public void GetReady()
    {
        GameManager.AdvanceLevel();
        GameManager.SetGameState(GameState.READY);
        SceneManager.LoadScene("ready");
    }

    void Start()
    {
        ScoreMessage.text = "You made "+ GameManager.instance.score +" Cookies."; //DEMO ONLY
        if (NextButton != null)
            NextButton.onClick.AddListener(() => { GetReady(); });
    }

}
