using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] audioClips;

    public void PlayAudioClip(int index)
    {
        if (index >= 0 && index < audioClips.Length)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.clip = audioClips[index];
                audioSource.Play();
            }
        }
    }

    public void StopAudio()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
}
