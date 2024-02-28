using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject Fireball;
    private GameObject _newball;
    private int _count = 0;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Fireball"))
        {

            Invoke("Delay", 1f);
              
            
        }
    }
    private void Delay()
    {
        _newball = Instantiate(Fireball);

    }

}
