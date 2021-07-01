/*Nombre completo:Angel David Villegas Cruz
Asignatura:Programacion orientada a objetos
Nombre y número de ejercicio: Ej5 Colision con item 
Descripción de los que hace el script: Aqui se declara el item y como se colisiona con el personaje
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Orbe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Personaje")
        {
            Destroy(this.gameObject);
        }
        //al momento de que el personaje toque el orbe este desaparece  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
