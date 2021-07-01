/*Nombre completo:Angel David Villegas Cruz
Asignatura:Programacion orientada a objetos
Nombre y número de ejercicio: Ej Spawuneo de Enemigos 
Descripción de los que hace el script: Aqui se generea la condicion para que se genere un enemigo 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{

    public GameObject enemigo;
    public float MaxX;
    public float MinX;
    public float MaxY;
    public float MinY;

    public float tiempo;
    private float spawn;

  
    // Update is called once per frame
    void Update()
    {
           
        if(Time.time > spawn)
        {
            Spawn();
            spawn = Time.time + tiempo;

        }
    }

    void Spawn()
    {
        float randomX = Random.Range(MinX, MaxX);
        float randomY = Random.Range(MinY, MaxY);


        Instantiate(enemigo, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
