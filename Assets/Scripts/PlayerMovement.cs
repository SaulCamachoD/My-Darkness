using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 30;
    public float jumpForce = 10;
    private float horizontalInput;
    private float forwardInput;
    public float turnSpeed = 5.0f;
    public bool isOnGround = true;
    public Animator animator;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        animator.SetBool("Run", true);
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetTrigger("Jump");
            isOnGround = false;
        }
    }

    void FixedUpdate()
    {
        Vector3 forwardVelocity = transform.forward * speed;
        playerRb.velocity = new Vector3(forwardVelocity.x, playerRb.velocity.y, forwardVelocity.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }

}
