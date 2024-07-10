using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public float velocidadMovimiento = 5f; 
    public float velocidadGiro = 100f;
    public Animator animator;
    private float inputHorizontal;
    private float inputVertical;

    private void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal"); // Obtiene la entrada horizontal (A/D o izquierda/derecha)
        inputVertical = Input.GetAxis("Vertical"); // Obtiene la entrada vertical (W/S o arriba/abajo)
        animationsCharacter();
        Vector3 movimiento = new Vector3(inputHorizontal * velocidadMovimiento, 0f, inputVertical * velocidadMovimiento); // Crea un vector de movimiento basado en la entrada
        transform.Translate(movimiento * Time.deltaTime); // Aplica el movimiento al personaje

        float giro = inputHorizontal * velocidadGiro * Time.deltaTime; // Calcula la cantidad de giro
        transform.Rotate(0f, giro, 0f);
    }

    public void animationsCharacter()
    {
        animator.SetFloat("Walk", inputHorizontal);
        animator.SetFloat("Walk", inputVertical);
    }
}

