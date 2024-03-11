using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navegation_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void navegar_a(ref int parametro)
    {
        Debug.Log("Navegation Manager: el modulo1 solicita navegar a la ventana:" + parametro);   
    }
}
