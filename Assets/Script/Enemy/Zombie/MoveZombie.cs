using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZombie : MonoBehaviour
{
    public Transform positionPlayer;
    public float speed=3f;
    public Animator anim;
    public bool seguir = false;

    
    void Update()
    {
        if (!seguir)
        {
            anim.SetBool("Walk", false);
            return;
        }
        if (positionPlayer != null) // Verificar que la referencia al jugador no sea nula
        {
            
            Vector3 direccion = positionPlayer.position - transform.position;
            direccion.Normalize(); 

     
            transform.Translate(direccion * speed * Time.deltaTime);
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            seguir = true;
            anim.SetBool("Walk", true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("Attack");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        seguir = false;
    }
}
