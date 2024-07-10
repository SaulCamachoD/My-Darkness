using UnityEngine;
using TMPro;

public class SinkInteraction : MonoBehaviour
{
    public TextMeshProUGUI interactionMessage; // Referencia al texto de la UI
    private bool isNearSink = false; // Bandera para verificar si el personaje está cerca del Sink
    private bool messageDisplayed = false; // Bandera para verificar si el segundo mensaje ha sido mostrado

    void Start()
    {
        interactionMessage.gameObject.SetActive(false); // Asegúrate de que el mensaje esté oculto al inicio
    }

    void Update()
    {
        // Detectar si el jugador presiona la tecla "X" cuando está cerca del Sink y el segundo mensaje no ha sido mostrado
        if (isNearSink && Input.GetKeyDown(KeyCode.X) && !messageDisplayed)
        {
            // Cambiar el mensaje en la UI
            interactionMessage.text = "...";
            messageDisplayed = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sink")
        {
            interactionMessage.text = "Presiona X para ver";
            interactionMessage.gameObject.SetActive(true);
            isNearSink = true; // El personaje está cerca del Sink
            messageDisplayed = false; // Resetear el mensaje mostrado
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Sink")
        {
            interactionMessage.gameObject.SetActive(false);
            isNearSink = false; // El personaje se alejó del Sink
        }
    }
}