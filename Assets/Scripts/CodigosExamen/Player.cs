/*Nombre completo:Angel David Villegas Cruz
Asignatura:Programacion orientada a objetos
Nombre y número de ejercicio: Ej2 Retroalimantacion y UI 
Descripción de los que hace el script: Aqui se declaran los datos de vida y todo lo que se presentara en pantalla
al momento de cargar elpersonaje 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseJugadores
{
    //se declaran los datos
    public int playerId;

    public string nombre;
    public string items;

    public float vida;
    
    public float velocidad;

    public float score;

    BaseJugadores bdJugadores;

    //se le dice que encuentr un bojeto (el jugador)
    private void Start() 
    {
        bdJugadores=GameObject.FindObjectOfType<BaseJugadores>();

        CargarDatos(playerId);

        
        
    }
     
    //Se dice que al momento de generar un jugador se le cargen los datos  
    void CargarDatos(int id)
    {
        for (int i = 0; i < bdJugadores.nuevoJugador.Length; i++)
        {

            if (bdJugadores.nuevoJugador[i].playerId==id)
            {
                this.nombre= bdJugadores.nuevoJugador[i].nombre;
                this.vida= bdJugadores.nuevoJugador[i].vida;
                this.velocidad= bdJugadores.nuevoJugador[i].velocidad;
                this.score= bdJugadores.nuevoJugador[i].score;
                this.items= bdJugadores.nuevoJugador[i].items;
            }
            
        }
    }

}
