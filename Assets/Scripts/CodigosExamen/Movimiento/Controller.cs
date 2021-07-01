/*Nombre completo:Angel David Villegas Cruz
Asignatura:Programacion orientada a objetos
Nombre y número de ejercicio: Ej1 controlador 
Descripción de los que hace el script: Aqui se declaran los keycode para detonar 
las animaciones y el movimiento 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Animator Run;
    Animator Back;

    // Start is called before the first frame update
    void Start()
    {
        Run = GetComponent<Animator>();
        Back = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Run.SetBool(name: "Run", value:true);
        }
        else
        {
            Run.SetBool(name: "Run", value:false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Run.SetBool(name: "Back", value:true);
        }
        else
        {
            Run.SetBool(name: "Back", value:false);
        }
    }
}
