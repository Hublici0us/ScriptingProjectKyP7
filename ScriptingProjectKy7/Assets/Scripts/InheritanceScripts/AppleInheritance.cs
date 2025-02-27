using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleInheritance : FruitInheritance
{
    public AppleInheritance()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called.");
    }

    public AppleInheritance(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called.");
    }
}
