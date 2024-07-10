using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDetections : MonoBehaviour
{
    public GameOverMenuController GameOverMenu;
    public PlayerMovement PlayerMovement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            GameOverMenu.ShowGameOverMenu();
            PlayerMovement.stopsaudio();
        }
    }
}
