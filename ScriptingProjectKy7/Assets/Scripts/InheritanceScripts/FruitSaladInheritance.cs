using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladInheritance : MonoBehaviour
{
    void Start()
    {
        print("Creating the fruit");
        FruitInheritance myFruit = new FruitInheritance();
        print("Creating the apple");
        AppleInheritance myApple = new AppleInheritance();

        // Calling methods of Fruit Class
        myFruit.SayHello();
        myFruit.Chop();

        // Calling methods of Apple Class.
        // Apple CClass has all methods of the class it inherited (Fruit).
        myApple.SayHello();
        myApple.Chop();

        Debug.Log("Creating the fruit.");
        myFruit = new FruitInheritance("yellow");
        Debug.Log("Creating the apple.");
        myApple = new AppleInheritance("green");

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();
    }

}
