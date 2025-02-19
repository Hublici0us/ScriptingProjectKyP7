using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClassGenerics
{
    // T can mean anything, such as string, int, float, etc. After the "where" is where we restrict the parameters of funcction T. It will only accept monobehaviours.
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
