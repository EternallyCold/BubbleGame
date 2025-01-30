using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class JellyfishCollisionDetector : MonoBehaviour
{
    public Rigidbody2D DetectionLeft;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("JellyfishCollision"))
        {
            JellyfishStop(DetectionLeft);
        }
    }

    public void JellyfishStop(Rigidbody2D rb)
    {
        rb.isKinematic = true;
        rb.velocity = new Vector2(0, 0);
    }

}

