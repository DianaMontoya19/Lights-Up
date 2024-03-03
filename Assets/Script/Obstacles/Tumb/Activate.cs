using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public Animator tumbActivate;
    void Start()
    {
        //tumbActivate.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            tumbActivate.enabled = true;
        }
        else
        {
            tumbActivate.enabled = false;
        }
    }
}
