using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto3Capilla : MonoBehaviour
{
    string frase = "Necesito sea como sea comunicarme con alguien.\n"+
                     "Debo encontrar algo con lo que poder hacerlo."; 
                   
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