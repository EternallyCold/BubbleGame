using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class JellyfishCollisionDetector : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("JellyfishCollision"))
        {
            JellyfishStop(gameObject.GetComponent<Rigidbody2D>());
        }
        else
        {

        }
    }

    public void JellyfishStop(Rigidbody2D rb)
    {
        rb.isKinematic = true;
        rb.velocity = new Vector2(0, 0);
    }

}

