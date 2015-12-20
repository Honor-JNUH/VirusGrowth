using System.Collections;
using System;
using UnityEngine;
using LitJson;

public enum GameState { SPLASH, READY, PLAY, PLAY_PAUSE, END, CONFIG }

public delegate void OnStateChangeHandler(); 

public class GameManager : MonoBehaviour {
    protected GameManager() { }
    public static GameManager instance = null;
    public event OnStateChangeHandler OnStateChange;
    public GameState gameState { get; private set; }
    public int level { get; private set; }
	public int score { get; private set; }

    void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(this);
        }
    }

    public void OnApplicationQuit() {
        GameManager.instance = null;
    }

    public static void SetGameState(GameState state) {
        instance.gameState = state;
        instance.OnStateChange();
    }

    public static void AdvanceLevel() {
        instance.level += 1;
    }

    public static void ResetRun() {
        instance.level = 1;
    }

	public static void AddScore(int s) {
		instance.score += s;
	}

}

//Credit goes to https://www.packtpub.com/books/content/creating-simple-gamemanager-using-unity3d
