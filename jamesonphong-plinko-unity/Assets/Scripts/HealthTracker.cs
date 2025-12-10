using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthTracker : MonoBehaviour
{
    // Reference to the TMP_Text component for displaying health + setting initial health
    public TMP_Text healthDisplay;
    public int health = 9000;

    private void Start()
    {
        UpdateHealthDisplay();
    }
    private void Update()
    {
        ZeroHealth();
    }
    public void deductHealth(int damage)
    {
        // Deduct health by the damage amount
        health -= damage;
        UpdateHealthDisplay();
    }
    public void UpdateHealthDisplay()
    {
        // Update the health display with leading zeros
        healthDisplay.text = $"HEALTH: {health,000000000}";
    }
    public void ZeroHealth()
    {
        // If health is 0 or less, load the WinScene
        if (health <= 0)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}