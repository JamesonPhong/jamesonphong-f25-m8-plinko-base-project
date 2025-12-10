using UnityEngine;

public class PlayerShootSFX : MonoBehaviour
{
    // Call upon a source of Audio
    public AudioSource audioSource;
    public void PlayShootFX()
    {
        // Play the audio source
        audioSource.Play();
    }
}
