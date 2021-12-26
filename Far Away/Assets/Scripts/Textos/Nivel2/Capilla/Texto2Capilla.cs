using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto2Capilla : MonoBehaviour
{
    string frase = "Todo esto hule muy mal, y noto una presencia muy extraña a mi alrededor. \n" + 
                    "Como si alguien me estuviera observando, cada vez un poco más cerca."; 
                   
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