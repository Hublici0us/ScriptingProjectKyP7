using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScriptQuaternion : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}
