/*Nombre completo:Angel David Villegas Cruz
Asignatura:Programacion orientada a objetos
Nombre y número de ejercicio: Ej2 Retroalimantacion y UI 
Descripción de los que hace el script: Aqui se genera un array de los personajes posibles y
los datos que se les generan (vida, score, ect.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJugadores : MonoBehaviour
{
    //Array 
    public ConstructorPlayer[] nuevoJugador;
    

    // Start is called before the first frame update
    void Awake()
    {

        //los datos que se generan y el personaje en cuestion 
        nuevoJugador= new ConstructorPlayer[3];

        nuevoJugador[0]= new ConstructorPlayer(1,"Will",5,10,"Llave",10);
        nuevoJugador[1]= new ConstructorPlayer(2,"Amy",9,7,"Llave",10);
        nuevoJugador[2]= new ConstructorPlayer(3,"Enemigo",10,6,"Llave",11);
        
    }

    
}
