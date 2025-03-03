using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcMemberHide : EnemyMemberHide
{
    // Hides enemy yell.
    new public void Yell()
    {
        Debug.Log("Orc YELL");
    }
}
