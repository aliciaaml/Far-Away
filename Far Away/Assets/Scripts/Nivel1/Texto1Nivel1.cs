using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto1Nivel1 : MonoBehaviour
{
    string frase = "Ufff… menos mal que he conseguido salir, pero ¿no está el pueblo como muy silencioso? \n"+
                    "¿Dónde está todo el mundo? Algo está pasando y debo averiguar qué es.";
                   
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