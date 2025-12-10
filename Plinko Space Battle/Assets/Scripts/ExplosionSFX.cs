using UnityEngine;

public class ExplosionSFX : MonoBehaviour
{
    // Call upon a source of Audio
    public AudioSource audioSource;
    public void ExplosionSoundFX()
    {
        // Play the audio source
        audioSource.Play();
    }
}
