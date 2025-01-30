using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCollisionAdd : MonoBehaviour
{
    public float timeLimit = 60f; // Time in seconds
    private float currentTime;

    // Time to add on collision
    public float timeToAdd = 10f;

    void Start()
    {
        currentTime = timeLimit;
    }

    void Update()
    {
        // Decrease time over time
        currentTime -= Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the player collides with a specific object
        if (collision.gameObject.CompareTag("Player"))
        {
            // Add time when colliding with the object
            currentTime += timeToAdd;

            // Optionally, make sure the time doesn't go below the original time limit
            if (currentTime > timeLimit)
            {
                currentTime = timeLimit;
            }

            // Optionally, you can print out the remaining time for debugging
            Debug.Log("Time after collision: " + currentTime);

            // Destroy the object after adding time (make sure time is added before destroying)
            Destroy(collision.gameObject);
        }
    }
}
