using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto6Movil : MonoBehaviour
{
    string frase =  "Su pueblo está muy lejos y el acceso es complicado. Asegúrese de encontrar un lugar seguro mientras llegan, por favor. Tendrá a alguien mañana a primera hora así que… \n"+
                    "***SIN SEÑAL***"; 
                   
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