using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("URP2DSceneTemplate");
    }

    public void OnPlayButtonClicked2()
    {
        SceneManager.LoadScene("main");
    }
}