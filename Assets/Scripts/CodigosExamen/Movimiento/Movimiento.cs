/*Nombre completo:Angel David Villegas Cruz
Asignatura:Programacion orientada a objetos
Nombre y número de ejercicio: Ej1 controlador 
Descripción de los que hace el script: Aqui se dedclaran los valores y la clase para que el 
personaje se mueva 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    [SerializeField]
    private float velocidadMovimiento;
    Animator animPlayer;

    public float speed = 10f;
    public float rotationSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void Update() 
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

       
    }
    

    
    
}
