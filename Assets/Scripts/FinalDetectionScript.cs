using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDetectionScript : MonoBehaviour
{
    public GameOverMenuController GameOverMenu;
    public PlayerMovement PlayerMovement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            GameOverMenu.ShowCongratulationMenu();
            PlayerMovement.stopsaudio();
        }
    }
}
