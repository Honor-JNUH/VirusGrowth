using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class End : MonoBehaviour
{
    public Button NextButton;
    public Text ScoreMessage;

    public void HandleOnStateChange() {
    }

    public void GetReady()
    {
        GameManager.AdvanceLevel();
        GameManager.SetGameState(GameState.READY);
        SceneManager.LoadScene("ready");
    }

    void Awake()
    {
        GameManager.instance.OnStateChange += HandleOnStateChange;
    }

    void Start()
    {
        ScoreMessage.text = "You made "+ GameManager.instance.score +" Cookies."; //DEMO ONLY
        if (NextButton != null)
            NextButton.onClick.AddListener(() => { GetReady(); });
    }

}
