using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    [SerializeField]
    private float velocidadMovimiento;
    
    [SerializeField]
    private float velocidadRotacion;

    [SerializeField]
    private float velocidadRotacionHorizontal;

    [SerializeField]
    private float velocidadRotacionVertical;

    public bool invertir;

    Animator animPlayer;

    // Start is called before the first frame update
    void Start()
    {
        invertir = true;
    }

    // Update is called once per frame
    void Update()
    {
        float h_Rotation = Input.GetAxisRaw("Mouse X");
        float v_Rotation = Input.GetAxisRaw("Mouse Y");


        controlPersonaje();
        LookAtAim(h_Rotation, v_Rotation);

        if (invertir  == false)
        {
            velocidadRotacionVertical =-velocidadRotacionVertical;
        }

       
    }

    private void LookAtAim()
    {
        float h_Rotation = Input.GetAxisRaw("Mouse X");
        Vector3 rotation_H= new Vector3(0,h_Rotation,0);
        rotation_H *=Time.deltaTime*velocidadRotacion;
        this.transform.Rotate(rotation_H);
    }

    //----- personaje first person


    private void LookAtAim(float h, float v)
    {
        float h_Rotation = h;
        float v_Rotation = v;
        Vector3 rotation= new Vector3(v_Rotation,h_Rotation,0);
        rotation.x *=Time.deltaTime*velocidadRotacionHorizontal;
        rotation.y *=Time.deltaTime*velocidadRotacionVertical;
        
        this.transform.localEulerAngles = new Vector3(rotation.y,rotation.x,0);
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
