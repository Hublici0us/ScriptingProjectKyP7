using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject spawnPrefab;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 3, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter >= 10)
        {
            CancelInvoke("SpawnObject");
        }
    }

    void SpawnObject()
    {
        float x = Random.Range(-2f, 2f);
        float z = Random.Range(-2f, 2f);
        Instantiate(spawnPrefab, new Vector3(x, 2, z), Quaternion.identity);
        counter++;
    }

    
}
