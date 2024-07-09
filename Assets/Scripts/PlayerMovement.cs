using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 30;
    public float jumpForce = 10;
    public float gravityModifier;
    public float horizontalInput;
    public float forwardInput;
    public float trunSpeed = 5.0f;
    public bool isOnGround = true;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        animator.SetBool("Run", true);

    }

    // Update is called once per frame
    void Update()
    {
        //This input allows us to move the player to the left and right.
        horizontalInput = Input.GetAxis("Horizontal");
        // using this codes

        transform.Translate(Vector3.right * Time.deltaTime * trunSpeed * horizontalInput);
        
        // when the user press space bar the player will jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetTrigger("Jump");
            // to avoid a doble jump , we have added this bool to know where is the ground
            isOnGround = false;
        }


        // This code allows us to move forward at a constant speed.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }

}
