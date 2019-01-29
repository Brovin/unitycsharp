using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveCar : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 7f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        straight();
    }

    void straight()
    {
        rb.MovePosition(transform.position + transform.forward * Time.deltaTime * speed);
    }
}
