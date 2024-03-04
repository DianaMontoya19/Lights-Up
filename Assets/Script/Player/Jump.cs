using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator anim;


    public bool jump;
    public LayerMask Ground;
    public Transform tf;
    public float force = 3f;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {


        float Ver = Input.GetAxisRaw(Vertical);


        jump = Physics2D.Raycast(tf.position, Vector2.down, 4f, Ground);

        if (Ver != 0 && jump)
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
    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object  
        Gizmos.color = Color.red;
        Vector3 direction = tf.TransformDirection(Vector3.down) * 3;
        Gizmos.DrawRay(tf.position, direction);
    }
}
