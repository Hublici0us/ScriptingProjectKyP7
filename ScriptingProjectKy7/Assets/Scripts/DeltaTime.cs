using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    public float speed = 8f;
    public float countdown = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)
        {
            GetComponent<Light>().enabled = true;
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
    }
}
