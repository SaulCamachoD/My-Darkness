using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    public MenuModel Model;
    public MenuController Controller;
    public Button buttonStart;
    public Button buttonTutorial;
    public Button buttonCredits;
    public Button buttonExit;
    public Button buttonReturn1;
    public Button buttonReturn2;
    void Start()
    {
        UpdateView(null,null);

        Model.OnOptionSelected += UpdateView;

        buttonStart.onClick.AddListener(() =>
        {
            Model.SelectOption(MenuModel.OptionsMenu.Start);
            Controller.StarGame();
        }); 
        
        buttonTutorial.onClick.AddListener(() =>
        { 
            Model.SelectOption(MenuModel.OptionsMenu.Tutorial);
            Controller.ViewTutorial();
        });

        buttonCredits.onClick.AddListener(() =>
        {
            Model.SelectOption(MenuModel.OptionsMenu.Credits);
            Controller.ViewCredits();
        });
        
        buttonExit.onClick.AddListener(() =>
        {
            Model.SelectOption(MenuModel.OptionsMenu.Exit);
            Controller.ExitGame();
        });
        
        buttonReturn1.onClick.AddListener(() =>
        {
            Model.SelectOption(MenuModel.OptionsMenu.Return);
            Controller.MainReturn();
        });
        
        buttonReturn2.onClick.AddListener(() =>
        {
            Model.SelectOption(MenuModel.OptionsMenu.Return);
            Controller.MainReturn();
        });

    }

    private void UpdateView(object sender, EventArgs e)
    {
        switch (Model.SelectedOption)
        {
            case MenuModel.OptionsMenu.Start:
                
                break;
            case MenuModel.OptionsMenu.Tutorial:
                
                break;
            case MenuModel.OptionsMenu.Credits:
                
                break;
            case MenuModel.OptionsMenu.Exit:
                
                break;
            case MenuModel.OptionsMenu.Return:
                
                break;
        }
    }
}
