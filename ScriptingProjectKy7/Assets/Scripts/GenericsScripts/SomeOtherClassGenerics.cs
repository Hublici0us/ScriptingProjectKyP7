using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassGenerics : MonoBehaviour
{
    void Start()
    {
        SomeClassGenerics someClass = new SomeClassGenerics();

        print(someClass.GenericMethod<int>(15));
    }
}
