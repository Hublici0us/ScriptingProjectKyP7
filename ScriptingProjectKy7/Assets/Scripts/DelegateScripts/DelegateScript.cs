using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour
{
    delegate void MyDelegate(int num); // This is like a blank function. Any created function can be made into this function.
    MyDelegate myDelegate;

    private void Start()
    {
        myDelegate = PrintNum;
        myDelegate(50);

        myDelegate = DoubleNum;
        myDelegate(50);
    }

    void PrintNum(int num)
    {
        print("Print num: " + num);
    }

    void DoubleNum(int num)
    {
        print("Print double num: " + num * 2);
    }
}
