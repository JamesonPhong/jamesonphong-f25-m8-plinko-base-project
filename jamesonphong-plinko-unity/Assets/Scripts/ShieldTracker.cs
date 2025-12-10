using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShieldTracker : MonoBehaviour
{
    // Reference to the TMP_Text component for displaying shield + setting initial shield + ShieldDownSFX script
    public TMP_Text shieldDisplay;
    public GameObject shieldObject;
    public int shield = 500;

    private void Start()
    {
        UpdateShieldDisplay();
    }
    private void Update()
    {
        ZeroShield(shieldObject);
    }
    public void deductShield(int damage)
    {
        // Deduct shield by the damage amount
        shield -= damage;
        UpdateShieldDisplay();
    }
    public void UpdateShieldDisplay()
    {
        // Update the shield display with leading zeros
        shieldDisplay.text = $"SHIELD: {shield,000000000}";
    }
    public void ZeroShield(GameObject shieldObject)
    {
        // If shield is 0 or less, destroy the Shield
        if (shield <= 0)
        {
            Destroy(shieldObject);
        }
    }
}
