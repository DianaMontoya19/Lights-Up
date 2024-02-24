using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStone : MonoBehaviour
{
    public Animator anim;
    public bool prueba = false;
    void Start()
    {
        anim=GetComponent<Animator>();  
    }

    void Update()
    {
        if(prueba)
        {
            anim.enabled = true;
            anim.SetBool("Move", prueba = true);
        }
        else
        {
            
            anim.SetBool("Move",prueba = false);
            //anim.enabled = false;
        }
        
    }
}
