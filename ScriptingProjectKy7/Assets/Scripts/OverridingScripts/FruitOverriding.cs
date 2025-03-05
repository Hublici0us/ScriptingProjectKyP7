using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitOverriding
{
    public FruitOverriding()
    {
        Debug.Log("1st Fruit Called");
    }

    public virtual void Chop () // This void can be overriden by child functions because it uses keyword virtual.
    {
        Debug.Log("Fruit chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, am fruit.");
    }
}
