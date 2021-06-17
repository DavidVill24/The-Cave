using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class ConstructorPlayer 
{
    public int playerId;

    public string nombre;
        
    public float vida;

    public float velocidad;

    private Transform posicionActual;

    private int daño;


    //Metodo constructor
    public ConstructorPlayer(int playerId, string n, float vida, float vel)
    {
        this.playerId=playerId;
        this.nombre=n;
        this.vida=vida;
        this.velocidad=vel;

    }
}
