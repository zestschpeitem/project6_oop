using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Enemy : MonoBehaviour
{
    public GameObject player;
    private Vector3 startposition;
    public Vector3 endposition;
    private int hp = 150;
    private bool select_igrok;

    public void move()
    {
        transform.position = player.transform.position;
        float cord_x = transform.position.x;
        float cord_y = transform.position.y;
        float cord_z = transform.position.z;
        startposition = new Vector3(cord_x, cord_y, cord_z);
    }


    [ContextMenu("move")]
    public void peremechenie()
    {
        transform.position = Vector3.Lerp(startposition, endposition, 1);
    }

    public virtual void Attack()
    {
        Debug.Log("Attack all around you");
    }


    [ContextMenu("poluch_damag")]
    public virtual void poluch_damag()
    {
        if (hp > 0)
        {
            hp = hp - 10;
            Debug.Log("You have 10 urona");
        }
        if (hp == 0)
        {
            hp = 0;
            Debug.Log("You are death");
            Destroy(gameObject);
        }
    }

}