using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller1 : MonoBehaviour
{
    Navegation_Manager class_Navegation_Manager;
    View1 class_View1;
    public void inicializacion_del_modulo()
    {
        class_Navegation_Manager = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<Navegation_Manager>();
        class_View1 = GameObject.FindGameObjectWithTag("Ventana1MenuInicial").GetComponent<View1>();
        class_View1.inicializacion_de_la_view();

    }

    // Update is called once per frame
    public void evento(ref int parametroController)
    {
        Debug.Log("Controller1:la vista me envia este numero de ventana" +parametroController);
        class_Navegation_Manager.navegar_a(ref parametroController);
    }
}
