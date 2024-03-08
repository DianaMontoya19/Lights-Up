using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public Key detection;
    public Animator anim;
    void Start()
    {
        detection = GetComponent<Key>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(detection._collection && collision.gameObject.CompareTag("Door"))
        {
            anim.enabled = true;
            StartCoroutine(Position());
        }
    }

    IEnumerator Position()
    {
        yield return new WaitForSeconds(1f);
        transform.position = transform.position + new Vector3(-57f,-17f,0f);

    }
}
