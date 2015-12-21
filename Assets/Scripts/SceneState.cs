using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class SceneState : MonoBehaviour
{
    protected GameManager GM { get { return GameManager.instance; } }

    public void HandleOnStateChange() {}
    
    void Awake()
    {
        GameManager.instance.OnStateChange += HandleOnStateChange;
    }

}
