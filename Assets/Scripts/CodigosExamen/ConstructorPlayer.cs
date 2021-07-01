/*Nombre completo:Angel David Villegas Cruz
Asignatura:Programacion orientada a objetos
Nombre y número de ejercicio: Ej2 Retroalimantacion y UI 
Descripción de los que hace el script: Aqui se dice que tipo de dato son los atrivutos del personaje
al igual de cuales son publicos privados o serialized field 
*/
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
    public string items
    {
        get
       {
          return items;   
       }
       set
       {  
          items=value;
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
    public float score
    {
        get
       {
          return score;   
       }
       set
       {  
          score=value;
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
    public ConstructorPlayer(int playerId, string n, float vida, float vel, string it, float sc)
    {
        this.playerId=playerId;
        this.nombre=n;
        this.items=it;
        this.vida=vida;
        this.score=sc;
        this.velocidad=vel;

    }
}
