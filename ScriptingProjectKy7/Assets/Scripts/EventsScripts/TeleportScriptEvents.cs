using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScriptEvents : MonoBehaviour
{
    void OnEnable()
    {
        EventsManager.onClicked += Teleport;
    }

    void OnDisable()
    {
        EventsManager.onClicked -= Teleport;
    }

    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(0f, 3f);
        transform.position = pos;
    }
}
