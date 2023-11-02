using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTimer : MonoBehaviour
{
    float coffeeTemperature = 100.0f;
    float tooHot = 80.0f;
    float tooCold = 65.0f;



    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            coffeeTemperature = coffeeTemperature + 5f;
        }
            coffeeTemperature -= Time.deltaTime * 5;
    }

    void TemperatureTest()
    { 
        if(coffeeTemperature > tooHot)
        {
            Debug.Log("Coffee is too hot!!");
        }
            
        else if(coffeeTemperature < tooCold)
        {
            Debug.Log("Coffee is freezing cold!!");
        }
        
        else
        {
            Debug.Log("mmmmmm delicious");
        }
    }
}
