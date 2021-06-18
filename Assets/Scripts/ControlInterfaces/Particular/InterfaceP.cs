using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceP : MonoBehaviour
{
    [Header("Interfaces basicas")]
    public Text nombreTXT;
    public Text vidaTXT;

    [Header("Interfaces TMPro")]
    public TMP_Text nombreTXTP;
    public TMP_Text vidaTXTP;

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
        if (nombreTXTP !=null)
        {
            nombreTXTP.text=playerData.nombre;
        }
        if (vidaTXTP !=null)
        {
            vidaTXTP.text=playerData.vida.ToString();
        }
         
         
        
    }
}
