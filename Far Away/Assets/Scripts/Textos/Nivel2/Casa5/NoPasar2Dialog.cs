using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoPasar2Dialog : MonoBehaviour
{

    public static string frase = "La iglesia está más atrás. De seguro allí están todos.\n"+
                                  "¿Qué será tan importante?";
                   
    public Text dialogo;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    public IEnumerator Reloj()
    {
        dialogo.text="";
        EsconderTexto.run=true;
        foreach (char caracter in frase)
        {
            dialogo.text = dialogo.text + caracter;
            yield return new WaitForSeconds(0.07f);
        }
        EsconderTexto.run=false;
   } 
}
