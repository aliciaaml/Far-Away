using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoRadio : MonoBehaviour
{


    string frase = " Oh no, la radio no funciona!! \n"+
                    "Tendré que buscar otra forma de comunicarme..";
                   
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
