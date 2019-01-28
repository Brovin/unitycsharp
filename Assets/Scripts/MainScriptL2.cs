using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScriptL2 : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            anim.SetBool("BoolCube", true);
        }
    }
}
