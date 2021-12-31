using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoFinalN3 : MonoBehaviour
{
    string frase = "Hola? . . . \n" + "Vaya, parece que se ha cortado.\n"+
                    "Creo que lo mejor será ir a casa. Allí estaré más seguro.";
                   
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