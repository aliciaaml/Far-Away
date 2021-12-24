using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto2Nivel2 : MonoBehaviour
{
    public static string frase = "... parece que no me escuchan o no están aquí. \n"+
                                 "La casa del Padre está cerca, debería ir a preguntarle."; 

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
