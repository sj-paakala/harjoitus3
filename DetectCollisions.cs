using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Destroy animal gameObject on collision
        Destroy(gameObject);
        // Destroy projectile on collision
        Destroy(other.gameObject);
    }
}
