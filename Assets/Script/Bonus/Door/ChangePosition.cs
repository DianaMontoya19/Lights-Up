using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangePosition : MonoBehaviour
{
    [SerializeField] private Key detection;
    public Animator anim;
    public Transform newPosition;
    
    void Start()
    {
        detection = FindObjectOfType<Key>();
    }

 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(detection._collection && collision.gameObject.CompareTag("Door"))
        {
            
            anim.enabled = true;
            StartCoroutine(Position());
            if(detection.count ==1)
            {                
              
                SceneManager.LoadScene("Winner");
            }
      
        }

    }

    IEnumerator Position()
    {
        yield return new WaitForSeconds(1f);
        transform.position = newPosition.position;

    }
}
