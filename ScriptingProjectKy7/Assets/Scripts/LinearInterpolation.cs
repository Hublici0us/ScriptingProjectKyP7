using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    // 1st parameter: interpolate (find inside) from
    //2nd paramerter; interpolate to
    //3rd paramter; where and how much to interpolate
    /* think like a line between the first and second value. the
     * last parameter specifies where on the line to pick.
     */

    /* 
     result will be 4.

    float result = Mathf.Lerp(3f, 5f, 0.5f);
    Vector3 from = new Vector3(1f, 2f, 3f);
    Vector3 to = new Vector3(5f, 6f, 7f);
    */
   
    //Here result = (4,5,6)
    //Vector3 interp = Vector3.Lerp(from, to, 0.75f);

    /*
     void Update ()
    {
    //this makes it go like backwards exponential growth, 
    from 4, to 6, to 7, to 7.5, to yk
    //its like a black hole, you go fast 
    towards the center but the closer you get, the slowerr it is
    
    //the time.deltaTime makes it not every frrame but every second.
        light.intensity = Mathf.Lerp(light.intensity,8f,0.5f * time.deltaTime);
    }
     */
}
