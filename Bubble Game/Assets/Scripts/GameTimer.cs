using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public Timer timer;

    // The name of the scene to load when time runs out
    public string sceneToLoad = "LoseScreen";

    void Start()
    {
        timer = FindObjectOfType<Timer>();
    }

    void Update()
    {
        // Decrease time
        timer.timeRemaining -= Time.deltaTime;

        // Check if time is up
        if (timer.timeRemaining <= 0f)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        // Print a message to the console (optional)
        Debug.Log("Time's up! Changing to Game Over Scene!");

        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
