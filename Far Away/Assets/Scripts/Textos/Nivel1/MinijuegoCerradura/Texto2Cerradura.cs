using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto2Cerradura : MonoBehaviour
{
    string frase = "¿Debería intentar forzar la cerradura para salir? \n"+
                    "Creo que es la mejor opción. Tengo que salir para averiguar qué está pasando.";
                   
    public Text dialogo;

    public static bool enablig;
    

    // Start is called before the first frame update
    void Start()
    {
        enablig=false;
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
        enablig=true;
        EsconderTexto.run=false;
        
    }
}
