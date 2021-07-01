/*Nombre completo:Angel David Villegas Cruz
Asignatura:Programacion orientada a objetos
Nombre y número de ejercicio: Ej4 Sistema general de colisiones 
Descripción de los que hace el script: Aqui se presenta y genera la colision el personaje 
*/using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    //se declaran los datos de daño y la vida
     public float daño;

    public float vidaPlus;

        private void OnCollisionEnter(Collision other) 
    {
        //Inicia la capsula
        if (other.gameObject.tag == "Personaje")
        {
            other.gameObject.GetComponent<Daño>().damage(50);
        }
    }    //termina (el daño que se hace en la colision)
}
