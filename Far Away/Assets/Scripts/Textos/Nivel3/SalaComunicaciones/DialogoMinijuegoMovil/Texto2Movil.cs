using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto2Movil : MonoBehaviour
{
    string frase = "Ho-hola. Necesito que alguien venga a ayudarme. \n"+
                    "Algo raro está ocurriendo en mi pueblo. Todos están.. están.. muertos y no sé qué hacer. Ayuda, por favor. Alguien me está siguie---"; 
                   
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