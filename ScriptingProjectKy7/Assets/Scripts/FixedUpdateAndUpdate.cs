using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateAndUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }

    //ctrl + shift + m = monobehaviour wizard which can access many functions.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }


}
