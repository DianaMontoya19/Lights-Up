using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
   
    public bool condition = false;
   
    public Transform Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
           Player.position = transform.position;
           
           condition = true;
        }
    }

}
