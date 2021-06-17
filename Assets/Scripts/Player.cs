using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerId;

    public string nombre;

    public float vida;

    public float velocidad;

    BaseJugadores bdJugadores;

    private void Start() 
    {
        bdJugadores=GameObject.FindObjectOfType<BaseJugadores>();

        CargarDatos(playerId);

        
        
    }

    void CargarDatos(int id)
    {
        for (int i = 0; i < bdJugadores.nuevoJugador.Length; i++)
        {

            if (bdJugadores.nuevoJugador[i].playerId==id)
            {
                this.nombre= bdJugadores.nuevoJugador[i].nombre;
                this.vida= bdJugadores.nuevoJugador[i].vida;
                this.velocidad= bdJugadores.nuevoJugador[i].velocidad;
            }
            
        }
    }

}
