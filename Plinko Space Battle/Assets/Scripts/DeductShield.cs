using UnityEngine;

public class DeductShield : MonoBehaviour
{
    // Reference to the ShieldTracaker script and ExplosionSFX script
    public ShieldTracker shieldTracker;
    public ExplosionSFX explosionSFX;
    public int shield = 1;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // Deduct shield and destroy the colliding object upon collision + play explosion sound effect
        shieldTracker.deductShield(shield);
        Destroy(collider.gameObject);
        explosionSFX.ExplosionSoundFX();
    }
}
