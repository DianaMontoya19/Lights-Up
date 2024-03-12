using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    
    public Animator anim;
    public GameObject key;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            key.SetActive(true);
            Destroy(gameObject);

        }
       
    }

}
