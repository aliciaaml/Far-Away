using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoPuerProta : MonoBehaviour
{
    public static string frase = "Antes de volver a casa, debería ir a ver a mi vecino y preguntarle.";
                   
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
            yield return new WaitForSeconds(0.1f);
        }
        EsconderTexto.run=false;
   } 
}
