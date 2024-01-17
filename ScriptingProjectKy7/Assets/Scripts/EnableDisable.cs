using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{

    public Light theLight;

    // Start is called before the first frame update
    void Start()
    {
        theLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            theLight.enabled = !theLight.enabled;
        }
    }
}
