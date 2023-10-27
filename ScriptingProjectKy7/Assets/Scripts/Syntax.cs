using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{
    /* this is pretty lit man
     * you should stop
     * actually don't this is cool
     */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.y);

        if (transform.position.y < 10)
        if (transform.position.y > 1.1)
        {
            Debug.Log("I'M GONNA HIT THE GROUND!!!");
        }

        if (transform.position.y <= 1)
        {
            Debug.Log("oh thank god im alive");
        }
    }

}

