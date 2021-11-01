using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoNombre : MonoBehaviour
{
    string frase = "Bienvenido a Far Away, pero antes de andetrarse a su próxima aventura, le rogamos que introduzca un nombre a nuestro protagonista. \n"+
                   "Sugerencia: Se recomienda para una mayor integración con el juego y el personaje, que el jugador introduzca su nombre." ;
    public Text dialogo;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reloj());
    }

    IEnumerator Reloj()
    {
        foreach (char caracter in frase)
        {
            dialogo.text = dialogo.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
