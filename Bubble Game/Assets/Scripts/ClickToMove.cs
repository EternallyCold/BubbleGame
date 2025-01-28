using UnityEngine;

// This script assumes the player will have a Rigidbody2D attached
// and it won't work without it
// This line enforces that the object have a Rigidbody2D in the 
// Unity editor
[RequireComponent(typeof(Rigidbody2D))]
public class ClickToMove : MonoBehaviour
{
    // ------------------------------------------------
    // Public variables, visible in Unity Inspector
    // Use these for settings for your script
    // that can be changed easily
    // ------------------------------------------------

    // This variable will hold the speed the player will 
    // move at
    public float speed;
    // This variable will determine how close we get to 
    // the target point before stopping
    public float stopDistance;

    // ------------------------------------------------
    // Private variables, NOT visible in the Inspector
    // Use these for tracking data while the game
    // is running
    // ------------------------------------------------

    // This variable will hold the last point we touched
    // so we can keep moving to that point even after we
    // stop touching the screen
    private Vector2 targetPoint;

    // This variable will store the attached RigidBody 
    // so we can use it to move
    Rigidbody2D ourRigidbody;


    // ------------------------------------------------
    // Awake is called when the script is loaded
    // ------------------------------------------------
    void Awake()
    {
        // Get the rigidbody that we'll be using for movement
        ourRigidbody = GetComponent<Rigidbody2D>();

        // Set our target point to be our current position
        // so we don't start moving right away
        targetPoint = transform.position;
    }

    // ------------------------------------------------
    // Update is called once per frame
    // ------------------------------------------------
    void Update()
    {
        // If the mouse button is down or touch is detected...
        if (Input.GetMouseButton(0))
        {
            // Record the mouse / touch position as our target
            // Do this by using the camera to convert from screen 
            // coordinates to game world coordinates
            targetPoint = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        // How far away are we from the target?
        float distance = (targetPoint - (Vector2)transform.position).magnitude;

        // If we are farther away from our target than our minimum distance...
        if (distance > stopDistance)
        {
            // ... Move in the direction of our target

            // Get the direction
            // Subtract the current position from the target position to get a distance vector
            // Normalise changes it to be length 1, so we can then multiply it by our speed
            Vector2 direction = (targetPoint - (Vector2)transform.position).normalized;

            // Set the velocity
            ourRigidbody.velocity = direction * speed;
        }
    }
}
