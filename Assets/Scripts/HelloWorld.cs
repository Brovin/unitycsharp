using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public bool on = false;
    public int level = 1;
    public string text = "Hello_World";

    void Awake() {
        Debug.Log("Level is up to load");
    }
    void Start()
    {
        Debug.Log("Level is load");
    }

    // Update is called once per frame
    void Update()
    {
        if(on == true && level < 10) {
            level += 1;
            Debug.Log(text + " your level is = " + level);
        }
    }
}
