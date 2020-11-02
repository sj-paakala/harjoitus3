using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Top bound of spawn range
    private float topBound = 34;
    // Lower bound of spawn range
    private float lowerBound = 0;

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z > topBound)
        {
            // Destroy gameObject if it goes out of bounds
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            // Print game over to debug log if animal crosses lower bound
            Debug.Log("Game Over!");
            // Destroy game object if animal crosses lower bound
            Destroy(gameObject);
        }
        
    }
}
