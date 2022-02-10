using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Enemy
{

    [ContextMenu("Attack")]
    public override void Attack()
    {
        BoxCollider collider = player.AddComponent<BoxCollider>();
        collider.size = new Vector3(1, 1, 1); ;
        Debug.Log("warrior attack!");
        DestroyImmediate(collider);
    }
}
