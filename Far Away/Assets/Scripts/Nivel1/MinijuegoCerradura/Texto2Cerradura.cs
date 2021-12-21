using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto2Cerradura : MonoBehaviour
{
    string frase = "¿Debería intentar forzar la cerradura para salir? \n"+
                    "Creo que es la mejor opción. Tengo que salir para averiguar qué está pasando.";
                   
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
            yield return new WaitForSeconds(0.1f);
        }
        EsconderTexto.run=false;
    }
}
