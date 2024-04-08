using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Value type variable : stores a value, but changing a copy doesn't change the original
        Vector3 pos = transform.position; 
        pos = new Vector3(0, 2, 0);

        //Reference type variable : can reference a variable, changing copies change the original
        Transform tran = transform;
        tran.position = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
