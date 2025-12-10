using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartTheGame()
    {
        // Load the main game scene
        SceneManager.LoadScene("GameScene");
    }
}
