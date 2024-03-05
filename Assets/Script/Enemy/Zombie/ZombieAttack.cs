using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    public Animator anim;
    public Collider2D attack;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.CompareTag("Player"))
       {
            anim.SetTrigger("Attack");
       }
    }

    //public void Activar()
    //{
    //    attack.enabled = true;
    //}
    //public void Desactivar()
    //{
    //    attack.enabled = false;
    //}

}
