using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public float moveSpeed = 5f; // moveSpeed para controlar la velocidad de movimiento del personaje
    public float rotationSpeed = 700f; // Ajusta esta velocidad para que la rotación no sea ni muy rápida ni muy lenta

    public Animator animator; // Declara una variable pública animator para almacenar el componente Animator

    private Rigidbody rb; // Variable para almacenar el componente Rigidbody

    void Start()
    {
        // Obtener el componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Obtiene la entrada del usuario para los ejes horizontal y vertical
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        // Actualiza los parámetros del Animator
        animator.SetFloat("WalkX", horizontal);
        animator.SetFloat("WalkZ", vertical);

        if (direction.magnitude >= 0.1f)
        {
            // Rotar hacia la dirección de movimiento
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationSpeed, 0.1f);
            transform.rotation = Quaternion.Euler(0, angle, 0);

            // Mover al personaje usando el Rigidbody
            Vector3 moveDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);

            // Activar la animación de caminar
            animator.SetBool("isWalking", true);
        }
        else
        {
            // Desactivar la animación de caminar cuando no hay movimiento
            animator.SetBool("isWalking", false);
        }
    }
}
