using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reappear : MonoBehaviour
{
    public Position[] position;
    public SpriteRenderer gamer;
    
    //void Start()
    //{
    //    position = GetComponent<Position[]>();
        
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Spike"))
        {
            StartCoroutine(Desapear());
            foreach (Position t in position)
            {
                if (t.condition == true)
                {
                    gameObject.transform.position = t.Player.position;
                }
            }
            
        }
    }
    IEnumerator Desapear()
    {
        gamer.enabled = false;
        yield return new WaitForSeconds(1f);
        gamer.enabled = true;

    }
}
