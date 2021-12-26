using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameEnter : MonoBehaviour
{
    public GameObject tile;
    public GameObject exit;
    public GameObject radio;
    public GameObject flecha_salida;
    public static bool circularDisable=false;


    private void OnMouseDown()
    {
        if(EsconderTexto.boton_no){

            exit.SetActive(true);
            tile.SetActive(true);
            radio.SetActive(false);       
            flecha_salida.SetActive(false);
            circularDisable=true;
        }
      
        
    }
}
