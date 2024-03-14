using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject shaboinky;

    AnotherScript aS;
    YetAnotherScript YASSS;
    BoxCollider boxCol;

    // Start is called before the first frame update
    void Awake()
    {
        aS = GetComponent<AnotherScript>();
        YASSS = GetComponent<YetAnotherScript>();
        boxCol = shaboinky.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Start()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + aS.playerScore);
        Debug.Log("The player has died " + YASSS.numberOfPlayerDeaths);
    }
}
