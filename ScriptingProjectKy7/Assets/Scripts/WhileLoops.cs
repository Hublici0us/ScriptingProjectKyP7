using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int platesinSink = 5;

    // Start is called before the first frame update
    void Start()
    {
        while(platesinSink > 0)
        {
            Debug.Log("I've washed a plate!");
            platesinSink--;
            Debug.Log("Plates in the sink : " + platesinSink);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
