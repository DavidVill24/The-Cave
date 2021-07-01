using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class ConstructorPlayer 
{
    [SerializeField]
    public int playerId;
    [SerializeField]
    public string nombre;
    [SerializeField]
    public float vida;
    [SerializeField]
    public float velocidad;

    private Transform posicionActual;

    private int daño;

    public int PlayerId
    {
       get
       {
          return playerId;   
       }
       set
       {  
          playerId=value;
       }
    }

    public string Nombre
    {
        get
       {
          return nombre;   
       }
       set
       {  
          nombre=value;
       }
    }

    public float Vida
    {
        get
       {
          return vida;   
       }
       set
       {  
          vida=value;
       }
    }

    public float Velocidad
    {
        get
       {
          return velocidad;   
       }
       set
       {  
          velocidad=value;
       }
    }

    //Metodo constructor
    public ConstructorPlayer(int playerId, string n, float vida, float vel)
    {
        this.playerId=playerId;
        this.nombre=n;
        this.vida=vida;
        this.velocidad=vel;

    }
}
