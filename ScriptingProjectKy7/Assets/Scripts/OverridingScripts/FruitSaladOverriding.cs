using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS.Extensions.Common;
using UnityEngine;

public class FruitSaladOverriding : MonoBehaviour
{
    void Start()
    {
        AppleOverriding apple = new AppleOverriding();

        apple.SayHello();
        apple.Chop();

        FruitOverriding fruit = new FruitOverriding();
        fruit.SayHello();
        fruit.Chop();
    }
}
