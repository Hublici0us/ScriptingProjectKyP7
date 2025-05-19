using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] rooms;
    public string[] types = { "Disappearance", "Rearrangement", "Mimic", "Intruder", "Pure Form", "Electronic" };

    private void Start()
    {
        
    }

    private void RandomAnomaly()
    {
        int ChooseRoom = Random.Range(0, rooms.Length);
        int chooseAnomaly = Random.Range(0, rooms[ChooseRoom].transform.childCount);

        rooms[ChooseRoom].transform.GetChild(chooseAnomaly).gameObject.SetActive(true);
    }

    private void ChooseRoom()
    {

    }
}
