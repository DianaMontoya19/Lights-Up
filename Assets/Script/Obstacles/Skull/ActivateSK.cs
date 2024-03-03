using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ActivateSK : MonoBehaviour
{
    public Animator skActivate;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            skActivate.enabled = true;
            
        }

    }
    public void DiseableAnim()
    {
        skActivate.enabled = false;
    }



}
