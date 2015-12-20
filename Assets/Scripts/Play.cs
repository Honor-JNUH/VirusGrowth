using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Play : MonoBehaviour
{
    GameManager GM;
    public Button NextButton; //DEMO ONLY; Various winning/losing conditions should be implemented for the final game

    public void HandleOnStateChange() { 
    }

    public void EndPlaying()
    {
        Debug.Log("End of Level " + GM.level);
        GameManager.SetGameState(GameState.END);
        Application.LoadLevel("end");
    }

    void Awake()
    {
        GameManager.instance.OnStateChange += HandleOnStateChange;
    }

    void Start()
    {
        if (NextButton != null)
        {
            NextButton.onClick.AddListener(() => { EndPlaying(); });
        }
    }

}
