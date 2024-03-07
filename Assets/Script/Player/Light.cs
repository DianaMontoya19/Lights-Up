using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Light : MonoBehaviour
{
    public Light2D light;
    public GameObject fireFlies;
    public float multy = 0.5f;
    void Start()
    {
        light = GetComponent<Light2D>();
        light.intensity = 0f;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Timeline());
            fireFlies.SetActive(false);
        }
    }
    IEnumerator Timeline()
    {
        yield return new WaitUntil(Timer);
    }
    private bool Timer()
    {
        light.intensity += multy * Time.deltaTime;
        return light.intensity >= 3;
    }

}
