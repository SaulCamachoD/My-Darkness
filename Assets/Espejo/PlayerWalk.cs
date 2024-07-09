using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public float moveSpeed = 5f; // moveSpeed para controlar la velocidad de movimiento del personaje
    public float rotationSpeed = 700f; // Ajusta esta velocidad para que la rotación no sea ni muy rápida ni muy lenta

    public Animator animator;
    /*Declara una variable privada animator para almacenar el componente Animator 
      del personaje, que se usa para controlar las animaciones.*/

    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        /* Obtiene la entrada del usuario para los ejes horizontal y vertical.
         Input.GetAxis("Horizontal") devuelve un valor entre -1 y 1 basado en las teclas A y D
        (o las flechas izquierda y derecha), y Input.GetAxis("Vertical") devuelve un valor entre
         -1 y 1 basado en las teclas W y S (o las flechas arriba y abajo).*/

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        animator.SetFloat("Walk", horizontal);
        animator.SetFloat("Walk", horizontal);
        animator.SetFloat("Walk", vertical);
        animator.SetFloat("Walk", vertical);

        /*Crea un vector direction basado en las entradas horizontal y vertical. Este vector se normaliza
          para asegurar que su magnitud sea 1, independientemente de la dirección.*/

        if (direction.magnitude >= 0.1f)

        /*Comprueba si la magnitud del vector de dirección es mayor o igual a 0.1. Esto se hace para evitar 
          movimientos no deseados cuando la entrada del usuario es muy pequeña.*/

        {
            // ROTAR HACIA LA DIRECCION DE MOVIMIENTO
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            /*Calcula el ángulo objetivo hacia el cual debe rotar el personaje. 
            Mathf.Atan2(direction.x, direction.z) calcula el ángulo en radianes,
            y Mathf.Rad2Deg lo convierte a grados.*/

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationSpeed, 0.1f);
            /*Suaviza la rotación del personaje hacia el ángulo objetivo. Mathf.SmoothDampAngle ajusta
              la rotación actual (transform.eulerAngles.y) hacia el targetAngle, utilizando
              rotationSpeed y un tiempo de suavizado de 0.1 segundos.*/

            transform.rotation = Quaternion.Euler(0, angle, 0);
            /*Aplica la rotación suavizada al personaje usando Quaternion.Euler
              para crear una rotación en el eje Y.*/

            // MOVER AL PERSONAJE
            Vector3 moveDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            /*Calcula la dirección de movimiento del personaje. Esto se hace aplicando la rotación targetAngle 
              a un vector hacia adelante (Vector3.forward).*/

            transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
            /*Mueve al personaje en la dirección calculada, multiplicada por moveSpeed y Time.deltaTime
              para asegurar que el movimiento sea consistente independientemente de la tasa de cuadros 
              por segundo. Space.World se usa para mover el personaje en el 
              espacio mundial, no en el espacio local.*/

            // ACTIVAR LA ANIMACION AL CAMINAR
            animator.SetBool("isWalking", true);
            /*Activa la animación de caminar estableciendo el parámetro isWalking del Animator a true.
*/
        }
        else
        {
            // DESACTIVAR LA ANIMACION DE CAMINAR CUANDO NO HAY MOVIMIENTO
            animator.SetBool("isWalking", false);
        }
    }
}

