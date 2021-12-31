using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoSalaComun : MonoBehaviour
{
    public static string frase = "Cerrada.. Y tampoco parece que haya nadie dentro.\n"+
                                  "...Si no recuerdo mal, el alcalde tenía una copia de la llave en su despacho. Debería dirigirme hacia allí.";
                   
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
