using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStone : MonoBehaviour
{
    public Animator anim;
    public bool prueba = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("Player"))
        {
            anim.enabled = true;
            anim.SetBool("Move", prueba = true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("Move", prueba = false);
    }

    //void Update()
    //{
    //    if(prueba)
    //    {
    //        anim.enabled = true;
    //        anim.SetBool("Move", prueba = true);
    //    }
    //    else
    //    {

    //        anim.SetBool("Move",prueba = false);
    //        //anim.enabled = false;
    //    }

    //}

}
