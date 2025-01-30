using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float timeLimit = 60f; // Time in seconds
    private float currentTime;

    // The name of the scene to load when time runs out
    public string sceneToLoad = "GameOverScene";

    void Start()
    {
        currentTime = timeLimit;
    }

    void Update()
    {
        // Decrease time
        currentTime -= Time.deltaTime;

        // Check if time is up
        if (currentTime <= 0f)
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
