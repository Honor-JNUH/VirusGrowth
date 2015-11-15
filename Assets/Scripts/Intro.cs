using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {
    GameManager GM;
    
    public void HandleOnStateChange()
    {
        Debug.Log("OnStateChange!");
        Application.LoadLevel("ready");
    }

    public void StartGame()
    {
        //start game scene
        GM.SetGameState(GameState.READY);
        Debug.Log(GM.gameState);
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    
    void Awake()
    {
        GM = GameManager.Instance;
        GM.OnStateChange += HandleOnStateChange;
    }

    public void OnGUI()
    {
        //menu layout
        GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 800));
        GUI.Box(new Rect(0, 0, 100, 200), "Menu");
        if (GUI.Button(new Rect(10, 40, 80, 30), "Start"))
        {
            StartGame();
        }
        if (GUI.Button(new Rect(10, 160, 80, 30), "Quit"))
        {
            Quit();
        }
        GUI.EndGroup();
    }
}


//Credit goes to https://www.packtpub.com/books/content/creating-simple-gamemanager-using-unity3d
