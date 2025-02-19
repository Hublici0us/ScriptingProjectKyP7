using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExampleGenerics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenericClassGenerics<int> generics = new GenericClassGenerics<int>();

        generics.UpdateItem(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
