using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScriptQuaternions : MonoBehaviour
{
    public float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
    }
}
