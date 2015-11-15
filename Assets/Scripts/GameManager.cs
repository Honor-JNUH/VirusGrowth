using UnityEngine;
using System.Collections;
using System;

public enum GameState { SPLASH, READY, PLAY, PLAY_PAUSE, END, CONFIG }

public delegate void OnStateChangeHandler(); 

public class GameManager : UnityEngine.Object {
    protected GameManager() { }
    public static GameManager instance = null;
    public event OnStateChangeHandler OnStateChange;
    public GameState gameState { get; private set; }
    

    public static GameManager Instance {
        get {
            if (GameManager.instance == null) {
                DontDestroyOnLoad(GameManager.instance);
                GameManager.instance = new GameManager();
            }
            return GameManager.instance;
        }
    }


    public void SetGameState(GameState state) {
        this.gameState = state;
        OnStateChange();
    }


    public void OnApplicationQuit() {
        GameManager.instance = null;
    }

}

//Credit goes to https://www.packtpub.com/books/content/creating-simple-gamemanager-using-unity3d
