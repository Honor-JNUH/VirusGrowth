using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class COOKIES : MonoBehaviour {
    public Button CookieButton;
    public GameObject IDEACOOKIE;
    public const float ScreenWidth = 800;
    public const float ScreenHeight = 600;


    void SPAWNCOOKIE() {
        //ĹE͜ T͟ ̛     T́H ҉E R ̴E ̢ ͡B̨ E͞ ̧   C O O K͏I͘ ͞E

        Instantiate(IDEACOOKIE, RandomizeLocation(), Quaternion.identity);
        GameManager.AddScore(1);
    }

    Vector3 RandomizeLocation() {
        return new Vector3(Random.Range(0,ScreenWidth), Random.Range(0, ScreenHeight), 0);
    }

    void Start()
    {
        CookieButton.onClick.AddListener(() => { SPAWNCOOKIE(); });
    }
}
