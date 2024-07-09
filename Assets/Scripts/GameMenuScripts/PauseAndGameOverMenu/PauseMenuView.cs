using UnityEngine;
using UnityEngine.UI;
using System;

public class PauseMenuView : MonoBehaviour
{
    public PauseMenuModel pauseModel;
    public PauseMenuController pauseController;
    public Button resumeButton;
    public Button mainMenuButton;

    void Start()
    {
        UpdateView(null ,null);

        pauseModel.OnOptionSelected += UpdateView;

        resumeButton.onClick.AddListener(() =>
        {
            pauseModel.SelectOption(PauseMenuModel.PauseMenuOptions.Resume);
            pauseController.HidePauseMenu();
        });

        mainMenuButton.onClick.AddListener(() =>
        {
            pauseModel.SelectOption(PauseMenuModel.PauseMenuOptions.MainMenu);
            pauseController.LoadMainScene();


        });
    }

  

    private void UpdateView(object sender, EventArgs e)
    {
        switch (pauseModel.SelectedOption)
        {
            case PauseMenuModel.PauseMenuOptions.Resume:

                break;
            case PauseMenuModel.PauseMenuOptions.MainMenu:

                break;
        }
    }
}
