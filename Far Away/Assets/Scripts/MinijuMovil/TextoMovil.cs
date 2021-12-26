using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoMovil : MonoBehaviour
{
    string frase =  "Apenas hay cobertura, con esta no me es suficiente para poder llamar a emergencias.";
                   
    public Text dialogo;

    public static bool movil1terminado=false;
    

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
        movil1terminado=true;
    }
}