using UnityEngine;
// This script deducts health from the HealthTracker when a collision occurs
public class DeductHealth : MonoBehaviour
{
    // Reference to the HealthTracker script and ExplosionSFX script
    public HealthTracker healthTracker;
    public ExplosionSFX explosionSFX;
    public int health = 1;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // Deduct health and destroy the colliding object upon collision + play explosion sound effect
        healthTracker.deductHealth(health);
        Destroy(collider.gameObject);
        explosionSFX.ExplosionSoundFX();
    }
}