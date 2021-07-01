using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
     [SerializeField]
    private float velocidadMovimiento;
    Animator animPlayer;

    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;

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
  
    
    private void controlPersonaje()
    {
        float vertical=Input.GetAxis("Vertical");

        Vector3 direction=new Vector3(0,0,vertical);

        direction *=Time.deltaTime+velocidadMovimiento;

        bool directionForward = direction.z != 0? true:false;
        //this.transform.position += direction;

        this.transform.Translate(direction);
        animPlayer.SetBool("run",directionForward);
    }

    private void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space ))
        {
            animPlayer.SetTrigger("Jump");
        }
    }
}
