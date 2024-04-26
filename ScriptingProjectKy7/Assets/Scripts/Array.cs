using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " + (i + 1) + " is a " + players[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
