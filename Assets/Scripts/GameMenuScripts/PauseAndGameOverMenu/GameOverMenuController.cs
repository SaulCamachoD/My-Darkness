using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuController : MonoBehaviour
{
    public GameObject GameOverMenu;
    public GameObject CongralutationMenu;

    private void Start()
    {
        GameOverMenu.SetActive(false);
        CongralutationMenu.SetActive(false);    
    }

    public void ShowGameOverMenu()
    {
        GameOverMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void ShowCongratulationMenu()
    {
        CongralutationMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void HideGameOVerMenu()
    {
        GameOverMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }
    
    public void HideCongratulationMenu()
    {
       CongralutationMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void LoadMainMenuScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenuScene");
    }
    public void LoadMainScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("GameScene");
    }
}
