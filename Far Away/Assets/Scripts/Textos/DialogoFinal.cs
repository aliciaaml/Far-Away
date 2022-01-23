using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoFinal : MonoBehaviour
{
    string frase = "No no no, no puede ser que vaya a entrar.\n" +
                   "Está destruyendo la barricada.Esta no ha servido de nada.\n" +
                   "Va a entrar... Ya está entrando...  Voy a morir... ";

    public Text dialogo;

    // Start is called before the first frame update
   void Start()
    {
        StartCoroutine(Reloj());
    }

    IEnumerator Reloj()
    {
        EsconderTexto.run = true;
        foreach (char caracter in frase)
        {
            dialogo.text = dialogo.text + caracter;
            yield return new WaitForSeconds(0.07f);
        }
        EsconderTexto.run = false;
    }
}
