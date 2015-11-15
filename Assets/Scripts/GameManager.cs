using System.Collections;
using System;
using UnityEngine;

public enum GameState { SPLASH, READY, PLAY, PLAY_PAUSE, END, CONFIG }

public delegate void OnStateChangeHandler(); 

public class GameManager : MonoBehaviour {
    protected GameManager() { }
    public static GameManager instance = null;
    void Awake()
    {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { 
            Destroy(this);
        }
    }
    public event OnStateChangeHandler OnStateChange;
    public GameState gameState { get; private set; }
    public int Level { get; private set; }


    public void SetGameState(GameState state) {
        this.gameState = state;
        OnStateChange();
    }

    public void OnApplicationQuit() {
        GameManager.instance = null;
    }

    public void AdvanceLevel() {
        Level += 1;
    }

    public void ResetRun() {
        Level = 1;
    }

}

//Credit goes to https://www.packtpub.com/books/content/creating-simple-gamemanager-using-unity3d
