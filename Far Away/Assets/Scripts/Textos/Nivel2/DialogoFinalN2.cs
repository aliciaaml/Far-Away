using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoFinalN2 : MonoBehaviour
{
    string frase = "Algo debe andar mal con la señal.\n" +
                    "Lo mejor será que me dirija a la torre de comunicaciones para ver si algo está imposibilitando la señal.";
                   
    public Text dialogo;

    public static bool textoFinal2=false;
    

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
        textoFinal2=true;
        EsconderTexto.run=false;
    }
}