using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroState : MonoBehaviour {

    public void HandleOnStateChange() {
    }

    public void StartGame() {
        GameManager.ResetRun();

        GameManager.SetGameState(GameState.READY);
        SceneManager.LoadScene("ready");
    }

    public void Quit() { 
        Debug.Log("Quit!");
        Application.Quit();
    }

    void Start() {
        GameManager.instance.OnStateChange += HandleOnStateChange;
    }

    public void OnGUI() {
        GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 800));
        GUI.Box(new Rect(0, 0, 100, 200), "Menu");

        if (GUI.Button(new Rect(10, 40, 80, 30), "Start"))
            StartGame();

        if (GUI.Button(new Rect(10, 160, 80, 30), "Quit"))
            Quit();

        GUI.EndGroup();
    }
}


//Credit goes to https://www.packtpub.com/books/content/creating-simple-gamemanager-using-unity3d
