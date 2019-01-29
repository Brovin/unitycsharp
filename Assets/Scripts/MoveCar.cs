using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveCar : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float now;
    public float _1range;
    public float _2range;
    public Vector3 rotate;
    bool c = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(c == true)
        {
            straight();
        }
    }

    void OnMouseDown()
    {
        c = true;
    }

    void straight()
    {
        rb.MovePosition(transform.position + transform.forward * Time.deltaTime * speed);
        float carRotate = Mathf.Floor(transform.eulerAngles.y);
         if (transform.position.z > now)
            {
                if (carRotate >= _1range && carRotate <= _2range)
                {
                    transform.localRotation = Quaternion.Euler(rotate);
                    return;
                }
                Quaternion a = Quaternion.Euler(rotate * Time.fixedDeltaTime);
                rb.MoveRotation(transform.rotation * a);
        }
    }
}
