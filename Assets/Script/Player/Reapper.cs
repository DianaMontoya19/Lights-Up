using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Reapper : MonoBehaviour
{
    public SpriteRenderer player;
    public GameObject image;


    // Update is called once per frame
    //void Update()
    //{

    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Died"))
        {
            
            transform.position = gameObject.transform.position + new Vector3(-15f, 4f, 0f);
            StartCoroutine(TimeReap());

        }
        if (collision.gameObject.CompareTag("Died2"))
        {

            transform.position = gameObject.transform.position + new Vector3(-5f, 4f, 0f);
            StartCoroutine(TimeReap());

        }

    }
    IEnumerator TimeReap()
    {
        image.SetActive(true);
        //player.enabled = false;
        yield return new WaitForSeconds(2f);
        image.SetActive(false);
        //player.enabled = true;




    }

}
