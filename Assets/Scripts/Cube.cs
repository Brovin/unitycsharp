using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed;
    public Transform a;
    public UnityEventQueueSystem v;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if(true){
                transform.position = Vector3.MoveTowards(transform.position, a.position, Time.deltaTime * speed);
            }
        }
    }
}
