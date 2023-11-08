using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    int NumCount = 6;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I can count to 5!");
        for (int i = 0;i < NumCount; i++)
        {
            Debug.Log("Number : " +  i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
