using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorEvents : MonoBehaviour
{

    Renderer ren;

    private void Start()
    {
        ren = GetComponent<Renderer>();
    }
    private void OnEnable()
    {
        EventsManager.onClicked += TurnColor;
    }

    private void OnDisable()
    {
        EventsManager.onClicked -= TurnColor;
    }

    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        ren.material.color = col;
    }
}
