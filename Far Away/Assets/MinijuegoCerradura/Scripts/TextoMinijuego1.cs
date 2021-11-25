using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoMinijuego1 : MonoBehaviour
{
    string frase = "...... Que...? Qué está pasando? "+
                    " Porqué no se abre la puerta? ...\n"+
                    "Estoy encerrado... ";
                   
    public Text dialogo;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reloj());
    }
    
    IEnumerator Reloj()
    {
        foreach (char caracter in frase)
        {
            dialogo.text = dialogo.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }
    }
}