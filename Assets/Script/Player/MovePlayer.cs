using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    public string Horizontal;
    //public string Vertical;
    public float velocidadMove = 5f;
    public float force = 3f;
    public Animator anim;
    public bool jump;
    public LayerMask Ground;
    public Transform tf;
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

    private void FixedUpdate()
    {
        //float Ver = Input.GetAxisRaw(Vertical);

        jump = Physics2D.Raycast(tf.position, Vector2.down, 2f, Ground);

        if (Input.GetKeyDown(KeyCode.UpArrow) && jump)
        {

            rb.AddForce(Vector3.up * force, ForceMode2D.Impulse);

        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            anim.SetBool("Jump", true);
            //animator.SetTrigger("Salto");
            jump = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            
            anim.SetBool("Jump", false);
            jump = false;
        }
    }
    //public void OnCollisionStay2D(Collision2D collision)
    //{
    //    if (collision.collider.tag == "Ground")
    //    {
    //        anim.SetBool("Jump", true);
    //        //animator.SetTrigger("Salto");
    //        jump = true;
    //    }
    //}
    //public void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.collider.tag == "Ground")
    //    {
    //        Debug.Log("colision");
    //        anim.SetBool("Jump", false);
    //        jump = false;
    //    }
    //}
    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object  
        Gizmos.color = Color.red;
        Vector3 direction = tf.TransformDirection(Vector3.down) * 2;
        Gizmos.DrawRay(tf.position, direction);
    }
}
