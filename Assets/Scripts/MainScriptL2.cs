using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class MainScriptL2 : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 7f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
        if(transform.localPosition.z > 17 && Mathf.Floor(transform.eulerAngles.y) != 180) {
           transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        }
    }
}
