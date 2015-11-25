using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class End : MonoBehaviour
{
    GameManager GM;
    public Button NextButton;
    public Text ScoreMessage;

    public void HandleOnStateChange() {
    }

    public void GetReady()
    {
        GM.AdvanceLevel();
        GM.SetGameState(GameState.READY);
        Application.LoadLevel("ready");
    }

    void Awake()
    {
        GM = GameManager.instance;
        GM.OnStateChange += HandleOnStateChange;
    }

    void Start()
    {
        ScoreMessage.text = "You made "+GM.score+" Cookies."; //DEMO ONLY
        if (NextButton != null)
            NextButton.onClick.AddListener(() => { GetReady(); });
    }

}
