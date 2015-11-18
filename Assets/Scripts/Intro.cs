using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {
    GameManager GM;

    public void HandleOnStateChange() {
    }

    public void StartGame() {
        GM.ResetRun();
        Debug.Log(GM.Level);

        GM.SetGameState(GameState.READY);
        Debug.Log(GM.gameState);

        Application.LoadLevel("Ready");
    }

    public void Quit() { 
        Debug.Log("Quit!");
        Application.Quit();
    }

    void Start() {
        GM = GameManager.instance;
        GM.OnStateChange += HandleOnStateChange;
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
