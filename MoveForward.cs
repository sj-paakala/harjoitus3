using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Speed of movement
    public float speed = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3.forward = Z-axis. Moves object forward on every frame update
        transform.Translate(Vector3.forward * Time.deltaTime * speed);   
    }
}
