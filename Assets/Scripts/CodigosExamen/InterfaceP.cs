/*Nombre completo:Angel David Villegas Cruz
Asignatura:Programacion orientada a objetos
Nombre y número de ejercicio: Ej2 Retroalimantacion y UI 
Descripción de los que hace el script: Aqui se carga el dato tipo Ui para refrescar y representar los datos en el canvas 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceP : MonoBehaviour
{
    //Se cargan los datos tipo texto
    [Header("Interfaces basicas")]
    public Text nombreTXT;
    public Text vidaTXT;
    public Text scoreTXT;
    public Text itemsTXT;

    /*[Header("Interfaces TMPro")]
    public TMP_Text nombreTXTP;
    public TMP_Text vidaTXTP;
    */

    Player playerData;
    
    // Start is called before the first frame update
    void Start()
    {
        playerData=GetComponentInParent<Player>();

       StartCoroutine(AsignarDatos(0.1f));
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //aqui se dice que datos se necesitan refrescar 
    IEnumerator AsignarDatos(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        
        if (nombreTXT !=null)
        {
            nombreTXT.text=playerData.nombre;
        }
        if (vidaTXT !=null)
        {
            vidaTXT.text=playerData.vida.ToString();
        }
        if (scoreTXT !=null)
        {
            scoreTXT.text=playerData.score.ToString();
        }
        if (itemsTXT !=null)
        {
            itemsTXT.text=playerData.items.ToString();
        }


        /*if (nombreTXTP !=null)
        {
            nombreTXTP.text=playerData.nombre;
        }
        if (vidaTXTP !=null)
        {
            vidaTXTP.text=playerData.vida.ToString();
        }*/
         
         
        
    }
}
