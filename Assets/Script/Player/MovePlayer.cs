using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    public string Horizontal;
    public string Vertical;
    public float velocidadMove = 5f;
    public Animator anim;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float Hor = Input.GetAxisRaw(Horizontal);
        //float Ver = Input.GetAxisRaw(Vertical);

        transform.Translate(Hor*Time.deltaTime*velocidadMove, 0f,0f);
        anim.SetFloat("Velx", Hor);


    }
}
