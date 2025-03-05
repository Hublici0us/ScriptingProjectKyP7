using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleOverriding : FruitOverriding
{
    public  AppleOverriding()
    {
        Debug.Log("1st Apple Called");
    }

    public override void Chop() // Using the override keyword can make this function override the parent virtual void.
    {
        base.Chop(); // Using the base keyword can make it so instead of overriding, it will do the base function but also do whatever is after.
        Debug.Log("The Apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, am apple");
    }
}
