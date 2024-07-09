using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeMenusPauseAndGO : MonoBehaviour
{
    public PauseMenuController Pause;
    public GameOverMenuController GameOverMenu;

    private void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Pause.ShowPauseMenu();
        }
        
        if (Input.GetKey(KeyCode.O))
        {
            GameOverMenu.ShowGameOverMenu();
        }
        
        if (Input.GetKey(KeyCode.I))
        {
            GameOverMenu.ShowCongratulationMenu();
        }
    }
}
