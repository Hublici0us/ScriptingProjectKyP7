using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject lightnight;

    void Start()
    {
        Debug.Log("Active Self:" + lightnight);
        Debug.Log("Active in Hieracrchy:" + lightnight.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
