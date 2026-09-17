using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadThemeSelect()
    {
        SceneManager.LoadScene("ThemeSelect");
    }

    public void LoadFluxRoll()
    {
        SceneManager.LoadScene("FluxRoll");
    }

    public void LoadFireLevel()
    {
        SceneManager.LoadScene("FireLevel");
    }

    public void LoadHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}