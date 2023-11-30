using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int pineapples;

    public int lettuce;
    public int onions;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FruitMachine (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    private void VeggieMachine (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Veggies total: " + answer);
    }
}
