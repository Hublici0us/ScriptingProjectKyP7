using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondClassMethodOverloading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FirstClassMethodOverloading myClass  = new FirstClassMethodOverloading();

        print(myClass.Add(1, 2) + "\n" + myClass.Add("what up ", "guys its yaboi"));
    }
}
