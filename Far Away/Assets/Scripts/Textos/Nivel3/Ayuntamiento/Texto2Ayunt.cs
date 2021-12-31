using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto2Ayunt : MonoBehaviour
{
    string frase = "...Alcalde??!!!! \n" + 
                    " ¿por qué? ¿por qué me está pasando esto? ¿por qué soy el único que queda? Esto es peor que morir.";
                   
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