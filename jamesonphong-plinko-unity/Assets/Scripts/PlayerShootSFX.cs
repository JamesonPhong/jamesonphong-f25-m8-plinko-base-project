using UnityEngine;

public class PlayerShootSFX : MonoBehaviour
{
    public AudioSource audioSource;
    public void PlayShootFX()
    {
        audioSource.Play();
    }
}
