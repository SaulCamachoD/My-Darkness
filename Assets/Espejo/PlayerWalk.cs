using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public float velocidadMovimiento = 5f; 
    public float velocidadGiro = 100f;
    public Animator animator;
    private float inputHorizontal;
    private float inputVertical;

    public AudioSource audioSource; 
    public AudioClip pasos; 
    private void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal"); // Obtiene la entrada horizontal (A/D o izquierda/derecha)
        inputVertical = Input.GetAxis("Vertical"); // Obtiene la entrada vertical (W/S o arriba/abajo)
        animationsCharacter();
        Vector3 movimiento = new Vector3(inputHorizontal * velocidadMovimiento, 0f, inputVertical * velocidadMovimiento); // Crea un vector de movimiento basado en la entrada
        transform.Translate(movimiento * Time.deltaTime); // Aplica el movimiento al personaje

        float giro = inputHorizontal * velocidadGiro * Time.deltaTime; // Calcula la cantidad de giro
        transform.Rotate(0f, giro, 0f);

        HandleFootsteps();
    }

    public void animationsCharacter()
    {
        animator.SetFloat("Walk", inputHorizontal);
        animator.SetFloat("Walk", inputVertical);
    }

    private void HandleFootsteps()
    {
        // Verifica si el jugador se está moviendo
        if ((inputHorizontal != 0 || inputVertical != 0) && !audioSource.isPlaying)
        {
            audioSource.clip = pasos; // Asigna el clip de pasos al AudioSource
            audioSource.Play(); // Reproduce el sonido de pasos
        }
        // Detén el sonido cuando el jugador deja de moverse
        else if (inputHorizontal == 0 && inputVertical == 0 && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}

