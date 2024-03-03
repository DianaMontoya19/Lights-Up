using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    public string Horizontal;
    public string Vertical;
    public float velocidadMove = 5f;
    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
