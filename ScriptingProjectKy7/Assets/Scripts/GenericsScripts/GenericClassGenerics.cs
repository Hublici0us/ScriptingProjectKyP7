using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* This is a generic class T. Notice the generic type 'T'.
//'T' will be replaced with an actual type, as will also 
//instances of the type 'T' used in the class. */

public class GenericClassGenerics <T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
