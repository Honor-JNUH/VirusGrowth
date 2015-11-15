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
        Debug.Log("Going to level " + GM.Level);
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
        ScoreMessage.text = "You made "+GM.Score+" Cookies."; //DEMO ONLY
        if (NextButton != null)
            NextButton.onClick.AddListener(() => { GetReady(); });
    }

}
