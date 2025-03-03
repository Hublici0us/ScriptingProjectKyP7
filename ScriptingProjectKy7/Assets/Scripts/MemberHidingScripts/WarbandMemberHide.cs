using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarbandMemberHide : MonoBehaviour
{
    void Start()
    {
        HumanoidMemberHide human = new HumanoidMemberHide();
        HumanoidMemberHide enemy = new EnemyMemberHide();
        HumanoidMemberHide orc = new OrcMemberHide();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
