using UnityEngine;
using UnityEngine.UI;
using System;

public class GameOverMenuView : MonoBehaviour
{
    public GameOverMenuModel GOModel;
    public GameOverMenuController GOController;
    public Button mainMenuButton;
    public Button RestartButton;
    public Button mainMenuCongButton;
    public Button RestartCongButton;

    void Start()
    {
        UpdateView(null, null);

        GOModel.OnOptionSelected += UpdateView;

        mainMenuButton.onClick.AddListener(() =>
        {
            GOModel.SelectOption(GameOverMenuModel.GameOverMenuOptions.MainMenu);
            GOController.HideGameOVerMenu();
            GOController.LoadMainMenuScene();


        });

        RestartButton.onClick.AddListener(() =>
        {
            GOModel.SelectOption(GameOverMenuModel.GameOverMenuOptions.Restart);
            GOController.HideGameOVerMenu();
            GOController.LoadMainScene();

        });
        
        mainMenuCongButton.onClick.AddListener(() =>
        {
            GOModel.SelectOption(GameOverMenuModel.GameOverMenuOptions.MainMenu);
            GOController.HideCongratulationMenu();
            GOController.LoadMainMenuScene();

        });

        RestartCongButton.onClick.AddListener(() =>
        {
            GOModel.SelectOption(GameOverMenuModel.GameOverMenuOptions.Restart);
            GOController.HideCongratulationMenu();
            GOController.LoadMainScene();

        });
    }

    private void UpdateView(object sender, EventArgs e)
    {
        switch (GOModel.SelectedOption)
        {
            case GameOverMenuModel.GameOverMenuOptions.MainMenu:

                break;
            case GameOverMenuModel.GameOverMenuOptions.Restart:

                break;
        }
    }
}
