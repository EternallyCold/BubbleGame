using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSFX : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Col");

        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            Debug.Log("POP");
        }
    }
}
