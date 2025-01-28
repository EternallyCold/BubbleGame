using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BlockMovement : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;
    public float speed = 4f;
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;

    // awake is called before start
    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        //physicsBody.velocity.x = -1;

        // make a variable to hold our velocity
        // get the velocity from the rigidbody

        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = -speed;

        physicsBody.velocity = newVelocity;
    }

    public void MoveRight()
    {
        //physicsBody.velocity.x = 1;

        // make a variable to hold our velocity
        // get the velocity from the rigidbody

        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = speed;

        physicsBody.velocity = newVelocity;
    }

    public void MoveUp()
    {
        //physicsBody.velocity.y = 1;

        // make a variable to hold our velocity
        // get the velocity from the rigidbody

        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.y = speed;

        physicsBody.velocity = newVelocity;
    }

    public void MoveDown()
    {
        //physicsBody.velocity.y = -1;

        // make a variable to hold our velocity
        // get the velocity from the rigidbody

        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.y = -speed;

        physicsBody.velocity = newVelocity;
    }

}*/
