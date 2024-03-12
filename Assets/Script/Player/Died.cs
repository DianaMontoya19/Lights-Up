using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Died : MonoBehaviour
{
    public Image[] heart;
    public int life = 3;
    private int _heart = 0;
    public MovePlayer movePlayer;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        movePlayer = GetComponent<MovePlayer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Spike"))
        {
            heart[_heart].fillAmount = 0f;

            _heart++;
            life--;
            if (life <= 0 && _heart >=3)
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
        SceneManager.LoadScene("GameOver");
        
    }
}
