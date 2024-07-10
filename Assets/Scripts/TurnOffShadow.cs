using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffShadow : MonoBehaviour
{
    public float rotationAngle = 45f;
    public float rotationDuration = 1f;
    public GameObject shadow;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.transform.name == "Shadow")
        {
            StartCoroutine(RotatePlayerGradually());
        }
    }

    private IEnumerator RotatePlayerGradually()
    {
        Quaternion initialRotation = shadow.transform.rotation;
        Quaternion targetRotation = shadow.transform.rotation * Quaternion.Euler(0, rotationAngle, 0);
        float elapsedTime = 0f;

        while (elapsedTime < rotationDuration)
        {
            shadow.transform.rotation = Quaternion.Slerp(initialRotation, targetRotation, elapsedTime / rotationDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        shadow.transform.rotation = targetRotation;
    }
}
