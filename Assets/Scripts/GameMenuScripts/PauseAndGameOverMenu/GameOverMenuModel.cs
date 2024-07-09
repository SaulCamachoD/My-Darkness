using System;
using UnityEngine;

public class GameOverMenuModel : MonoBehaviour
{
    public enum GameOverMenuOptions
    {
        MainMenu,
        Restart
    }

    private GameOverMenuOptions selectedOption = GameOverMenuOptions.MainMenu;

    public GameOverMenuOptions SelectedOption
    {
        get { return selectedOption; }
        set
        {
            selectedOption = value;
            NotifyOptionChanged();
        }
    }

    public event EventHandler OnOptionSelected;

    private void NotifyOptionChanged()
    {
        OnOptionSelected?.Invoke(this, EventArgs.Empty);
    }

    public void SelectOption(GameOverMenuOptions option)
    {
        SelectedOption = option;
        NotifyOptionChanged();
    }
}
