using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ControllerLight : MonoBehaviour
{
    public Light2D playerLight;
    public GameObject fireFlies;
    public float multy = 0.5f;
    public float timer = 20f;
    private bool _timeOut = false;
    void Start()
    {
        playerLight = GetComponent<Light2D>();
        playerLight.intensity = 0f;
        
    }
    private void Update()
    {
        if (_timeOut == true)
        {
            timer-= Time.deltaTime;
            if (timer <= 0f)
            {
                StartCoroutine(TimeOff());
                timer = 20f;
                _timeOut = false;
                
                
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            _timeOut = true;
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
        playerLight.intensity += multy * Time.deltaTime;
        return playerLight.intensity >= 3;
    }
    IEnumerator TimeOff()
    {
        yield return new WaitUntil(TimerOff);
    }
    private bool TimerOff()
    {
        playerLight.intensity -= multy * Time.deltaTime;
        return playerLight.intensity <= 0;
    }

}
