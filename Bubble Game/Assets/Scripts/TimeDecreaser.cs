using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerModifier : MonoBehaviour
{
    public Timer timer;
    public float timeDecreaseAmount = 2f; // Amount to decrease when colliding with a target
    public float timeIncreaseAmount = 5f; // Amount to increase when colliding with a power-up
    public string targetTag = "Siren"; // Tag of the GameObject that decreases the timer
    public string powerUpTag = "Bubble"; // Tag of the GameObject that increases the timer

    private void Start()
    {
        timer = FindObjectOfType<Timer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the "Target" tag to decrease the timer
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Decrease the timer by the specified amount
            timer.timeRemaining -= timeDecreaseAmount;

            // Make sure timer doesn't go negative
            if (timer.timeRemaining < 0)
            {
                timer.timeRemaining = 0;
            }

            Debug.Log("Timer decreased!");
        }
        // Check if the collided object has the "PowerUp" tag to increase the timer
        else if (collision.gameObject.CompareTag(powerUpTag))
        {
            // Increase the timer by the specified amount
            timer.timeRemaining += timeIncreaseAmount;

            Debug.Log("Timer increased!");
        }
    }
}
