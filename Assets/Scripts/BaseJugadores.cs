 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJugadores : MonoBehaviour
{

    public ConstructorPlayer[] nuevoJugador;
    

    // Start is called before the first frame update
    void Awake()
    {
        nuevoJugador= new ConstructorPlayer[3];

        nuevoJugador[0]= new ConstructorPlayer(1,"Will",10,5);
        nuevoJugador[1]= new ConstructorPlayer(2,"Amy",9,7);
        nuevoJugador[2]= new ConstructorPlayer(3,"Enemigo",10,6);
        
    }

    
}
