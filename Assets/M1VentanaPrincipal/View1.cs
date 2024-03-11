using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View1 : MonoBehaviour
{
    Controller1 class_Controller1;

    public void inicializacion_de_la_view()
    {
        class_Controller1 = GameObject.FindGameObjectWithTag("Ventana1MenuInicial").GetComponent<Controller1>();
        
    }

    public void OnClick_botones( int parametroView) 
    {
        Debug.Log("view1:numerodeventanaes" + parametroView);

        class_Controller1.evento(ref parametroView);
    }
   
}
