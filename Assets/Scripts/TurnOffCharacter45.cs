using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCharacter45 : MonoBehaviour
{
    public float rotationAngle = 45f;
    public float rotationDuration = 1f;
    public GameObject player;

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.transform.name == "Player")
        {
            StartCoroutine(RotatePlayerGradually());
        }
    }

    private IEnumerator RotatePlayerGradually()
    {
        Quaternion initialRotation = player.transform.rotation;
        Quaternion targetRotation = player.transform.rotation * Quaternion.Euler(0, rotationAngle, 0);
        float elapsedTime = 0f;

        while (elapsedTime < rotationDuration)
        {
            player.transform.rotation = Quaternion.Slerp(initialRotation, targetRotation, elapsedTime / rotationDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        player.transform.rotation = targetRotation;
    }
}
