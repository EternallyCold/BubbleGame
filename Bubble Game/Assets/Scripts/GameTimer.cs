using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public float timeLimit = 60f; // Time in seconds
    private float currentTime;

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
        // Print a message to the console (you can replace this with a game over screen, etc.)
        Debug.Log("Time's up! Game Over!");

        // End the game
        // If you are testing in the Unity editor
        UnityEditor.EditorApplication.isPlaying = false;

        // If you are building the game, use:
        // Application.Quit();
    }
}
