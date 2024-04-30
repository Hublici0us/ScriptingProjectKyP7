using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    public GameObject spawnPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        Instantiate(spawnPrefab, new Vector3(0,2,0), Quaternion.identity);
    }
}
