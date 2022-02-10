using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Enemy
{
    [ContextMenu("Attack")]
    public override void Attack()
    {
        BoxCollider collider = player.AddComponent<BoxCollider>();
        collider.size = new Vector3(3, 3, 3);
        collider.center = endposition;
        Debug.Log("archer attack");
        DestroyImmediate(collider);
    }
}
