using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JellyfishCollisionDetector : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;
    public float speed = 3f;
    public Collider2D BarrierSensor = null;
    public LayerMask groundLayer = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");

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


}

