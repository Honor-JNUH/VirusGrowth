using System.Collections;
using System;
using UnityEngine;
using LitJson;

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
    public int level { get; private set; }
	public int score { get; private set; }

    public void SetGameState(GameState state) {
        this.gameState = state;
        OnStateChange();
    }

    public void OnApplicationQuit() {
        GameManager.instance = null;
    }

    public void AdvanceLevel() {
        level += 1;
    }

    public void ResetRun() {
        level = 1;
    }
	public void AddScore(int s) {
		score += s;
	}

}

//Credit goes to https://www.packtpub.com/books/content/creating-simple-gamemanager-using-unity3d
