using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveCar))]
public class TurnRight : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float carRotate = Mathf.Floor(transform.eulerAngles.y);
        if(transform.position.z > 13.5f && carRotate != 90)
        {
            if(carRotate >= 90 && carRotate <= 94)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0, 90f, 0));
            }
            Quaternion a = Quaternion.Euler(new Vector3(0, 90f, 0) * Time.fixedDeltaTime);
            rb.MoveRotation(transform.rotation * a);
        }
    }
}