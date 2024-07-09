using UnityEngine;

public class ProbeAudioManager : MonoBehaviour
{
    public AudioManager audioManager;


    private void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            audioManager.PlayAudioClip(0);
            print("yes");
        }
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            audioManager.PlayAudioClip(1);
            print("no");
        }

        if (Input.GetKey(KeyCode.J))
        {
            audioManager.PlayAudioClip(2);
            print("TalVez");
        }


    }
}
