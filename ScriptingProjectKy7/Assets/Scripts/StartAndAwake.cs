using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAndAwake : MonoBehaviour
{


    void Awake()
        // this goes before start
    {
        Debug.Log("I CALL FIRST, said the awake function.");
        Debug.Log("1");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("DANG IT, said the start function.");
        Debug.Log("2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
