using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator anim;
    public Collider2D attack;

    
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Return)) {

            anim.SetTrigger("Attack");
           
            
        }

    }
    void Appear()
    {
        attack.enabled = true;
    }
    void Desactivar()
    {
        attack.enabled = false;
    }
}
