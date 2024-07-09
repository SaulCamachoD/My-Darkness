using System;
using UnityEngine;
using UnityEngine.Events;

public class PauseMenuModel : MonoBehaviour
{
    public enum PauseMenuOptions
    {
        Resume,
        MainMenu
    }

    private PauseMenuOptions selectedOption = PauseMenuOptions.Resume;

    public PauseMenuOptions SelectedOption
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

    public void SelectOption(PauseMenuOptions option)
    {
        SelectedOption = option;
        NotifyOptionChanged();
    }
}
