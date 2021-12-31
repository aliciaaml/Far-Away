using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoAyuntamiento : MonoBehaviour
{
    public static string frase = "Ahora no es momento de entrar al ayuntamiento, debo dirigirme a la torre de comunicaciones para arreglar la señal y llamar a emergencias.";
                   
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
