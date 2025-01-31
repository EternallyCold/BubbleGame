using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDelete : MonoBehaviour
{
    public AudioSource bubbleSound;
    public AudioSource sirenSong;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Col");

        if (other.gameObject.CompareTag("Bubble"))
        {
            bubbleSound.Play();
            Destroy(other.gameObject);
            Debug.Log("BUBBLES");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Siren"))
        {
            sirenSong.Play();
        }
    }
}
