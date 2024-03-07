using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Died : MonoBehaviour
{
    public int life = 3;
    public MovePlayer movePlayer;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        movePlayer = GetComponent<MovePlayer>();
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            life--;
            if(life <= 0)
            {
                movePlayer.enabled = false;
                anim.SetTrigger("Died");
                StartCoroutine(Wait());
                
            }
        }
    }
    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0f;
    }
}
