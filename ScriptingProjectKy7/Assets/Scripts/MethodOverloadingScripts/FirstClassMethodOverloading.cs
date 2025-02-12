using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstClassMethodOverloading
{
    // Methods can have the same name as long as their parameters are different.
    // The signature of a method is a combination of their name and their parameter list. No two methods can have the same signature.
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
}
