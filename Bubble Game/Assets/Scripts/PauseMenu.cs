using UnityEngine;
using UnityEngine.SceneManagement;  // For scene management (e.g., restart)
using UnityEngine.UI;  // For UI elements like buttons

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;  // Reference to the Pause Menu UI Canvas
    private bool isPaused = false;  // Track if the game is paused

    void Update()
    {
        // Toggle pause menu on pressing the "Escape" key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    // Function to open the pause menu and stop time
    void Pause()
    {
        pauseMenuUI.SetActive(true);  // Show the pause menu
        Time.timeScale = 0f;  // Freeze time (pause the game)
        isPaused = true;  // Set paused status to true
    }

    // Function to resume the game and close the pause menu
    public void Resume()
    {
        pauseMenuUI.SetActive(false);  // Hide the pause menu
        Time.timeScale = 1f;  // Resume time (unpause the game)
        isPaused = false;  // Set paused status to false
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
