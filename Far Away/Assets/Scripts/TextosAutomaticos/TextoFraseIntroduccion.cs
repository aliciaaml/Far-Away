using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoFraseIntroduccion : MonoBehaviour
{
    string frase = " ``Monsters are real, ghosts are real too.\n" + "They live inside us, and sometimes, they win´´ \n" + "-Stephen king ";
    public Text texto;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reloj());
    }
    
    IEnumerator Reloj()
    {
        foreach(char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.07f);
        }
    }
}
