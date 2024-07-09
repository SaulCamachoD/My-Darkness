using System;
using UnityEngine;

public class MenuModel : MonoBehaviour
{
    public enum OptionsMenu
    {
        Start,
        Tutorial,
        Credits,
        Exit,
        Return
    }

    private OptionsMenu selectedOption = OptionsMenu.Start;

    public OptionsMenu SelectedOption
    {
        get { return selectedOption; }
        set
        {
            selectedOption = value;
            NotifyChangeOption();
        }
    }

    public event EventHandler OnOptionSelected;

    private void NotifyChangeOption()
    {
        OnOptionSelected?.Invoke(this, EventArgs.Empty); 
    }

    public void SelectOption(OptionsMenu option)
    {
        SelectedOption = option;
        NotifyChangeOption();
    }
}
