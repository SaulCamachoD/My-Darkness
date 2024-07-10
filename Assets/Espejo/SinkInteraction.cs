using UnityEngine;
using TMPro;
using System.Collections;

public class SinkInteraction : MonoBehaviour
{
    public GameObject points;
    public GameObject instruction;
    public Minimanager minimanager;

    void Start()
    {
        points.gameObject.SetActive(false);
        instruction.gameObject.SetActive(false); 
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F) )
        {
            
            instruction.gameObject.SetActive(false);
            StartCoroutine(ChangeScene());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sink")
        {
            instruction.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Sink")
        {
            instruction.gameObject.SetActive(false);
        }
    }

    IEnumerator ChangeScene()
    {
        points.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        minimanager.ChangeScene();
    }
}