using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
     public float daño;

    public float vidaPlus;

        private void OnCollisionEnter(Collision other) 
    {
        //Inicia la capsula
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Daño>().damage(50);
        }
    }    //termina
}
