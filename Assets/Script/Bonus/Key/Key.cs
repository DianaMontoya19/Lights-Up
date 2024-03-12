using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool _collection = false;
    public GameObject[] key;
    public int count;
    
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            _collection = true;
            count = 0;
            Destroy(key[0]);
            
        }
        if (collision.gameObject.CompareTag("Key2"))
        {
            count = 1;
            _collection = true;
            Destroy(key[1]);
        }

        

    }

    
}
