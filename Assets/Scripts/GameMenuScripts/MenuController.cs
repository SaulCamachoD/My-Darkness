using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public MenuModel Model;
    public GameObject MainMenuPanel;
    public GameObject TutorialPanel;
    public GameObject CreditsPanel;

    private void Start()
    {
        CreditsPanel.SetActive(false);
        TutorialPanel.SetActive(false);
    }
    public void StarGame()
    {
        SceneManager.LoadScene("IntroductionScene");
    }

    public void ViewTutorial()
    {
        MainMenuPanel.SetActive(false);
        TutorialPanel.SetActive(true);
    }

    public void ViewCredits()
    {
        MainMenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }

    public void ExitGame()
    {
        print("Termina el juego");
        Application.Quit();
    }

    public void MainReturn()
    {
        MainMenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        TutorialPanel.SetActive(false);
    }
}
