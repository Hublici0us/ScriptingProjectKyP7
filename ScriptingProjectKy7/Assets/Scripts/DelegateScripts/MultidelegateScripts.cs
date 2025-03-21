using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultidelegateScripts : MonoBehaviour
{
    delegate void Multidelegate();
    Multidelegate multiDelegate;
    Renderer renderer;


    private void Start()
    {
        renderer = this.GetComponent<Renderer>();

        multiDelegate += PowerUp;
        multiDelegate += TurnRed;

        if (multiDelegate != null)
        {
            multiDelegate();
        }
    }

    void PowerUp()
    {
        print("Orb is powering up!");
    }

    void TurnRed()
    {
        renderer.material.color = Color.red;
    }
}
