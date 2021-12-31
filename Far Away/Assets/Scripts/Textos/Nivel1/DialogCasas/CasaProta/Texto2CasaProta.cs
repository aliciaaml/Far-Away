using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto2CasaProta : MonoBehaviour
{
    string frase = "Puede que estos muebles de madera me sirvan para protegerme.\n"+
                    "Podría desarmarlos y utilizar las piezas para montar una barricada en la ventana y la puerta."   ; 
                   
    public Text dialogo;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reloj());
    }
    
    IEnumerator Reloj()
    {
        EsconderTexto.run=true;
        foreach (char caracter in frase)
        {
            dialogo.text = dialogo.text + caracter;
            yield return new WaitForSeconds(0.07f);
        }
        EsconderTexto.run=false;
    }
}