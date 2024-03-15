using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    
    public string Horizontal;
    
    public float velocidadMove = 5f;

    public Animator anim;
    

    void Awake()
    {
        
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        float Hor = Input.GetAxisRaw(Horizontal);
        transform.Translate(Hor*Time.deltaTime*velocidadMove, 0f,0f);
        anim.SetFloat("Velx", Hor);

        if (Hor >= 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = true;

        }
        
    }




}
