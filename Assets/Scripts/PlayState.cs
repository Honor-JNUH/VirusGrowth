using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayState : MonoBehaviour
{
    
    public Button nextButton; //DEMO ONLY; Various winning/losing conditions should be implemented for the final game
    public Text hpText;
    public Text scoreText;

    public PlayerBehaviour player;

    GameManager GM;

    public void EndPlaying() {
        Debug.Log("End of Level " + GM.level);
        GameManager.SetGameState(GameState.END);
        SceneManager.LoadScene("end");
    }

    void Update() {
        hpText.text = player.health.ToString();
        //scoreText.text = GM.score.ToString();
    }

    void Start() {
        GM = GameManager.instance;
        if (nextButton != null)
            nextButton.onClick.AddListener(() => { EndPlaying(); });
    }

}
