using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public GameObject PauseMenu;

    private void Start()
    {
        PauseMenu.SetActive(false);
    }

    public void ShowPauseMenu()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void HidePauseMenu()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void LoadMainScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenuScene");
    }
}
