using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMovement : MonoBehaviour
{
    public float speed = 30;
    public Animator animator;
    public GameObject player;
    public GameOverMenuController GameOverMenu;
    public PlayerMovement PlayerMovement;

    private void Start()
    {
        animator.SetBool("Run", true);
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.transform.name == "Player")
        {
            GameOverMenu.ShowGameOverMenu();
            PlayerMovement.stopsaudio();
        }
    }
}
