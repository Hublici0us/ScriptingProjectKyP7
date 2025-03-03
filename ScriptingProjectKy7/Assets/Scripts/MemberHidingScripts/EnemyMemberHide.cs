using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMemberHide : HumanoidMemberHide
{
    // Hides the origginal Humanoid yell.
    new public void Yell()
    {
        Debug.Log("Enemy YELL");
    }
}
