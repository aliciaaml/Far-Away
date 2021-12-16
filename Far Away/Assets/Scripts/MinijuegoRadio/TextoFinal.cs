using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoFinal : MonoBehaviour
{
    string frase = "Oh no, la radio tampoco funciona. Algo debe andar mal con la señal. Lo mejor será que me dirija a la torre de comunicaciones para ver si algo está imposibilitando la señal ";
                   
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
