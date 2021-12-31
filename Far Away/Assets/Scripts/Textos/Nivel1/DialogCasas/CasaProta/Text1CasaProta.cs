using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text1CasaProta : MonoBehaviour
{
    string frase = "Vale... He llegado sano y salvo a casa, pero tengo que protegerme más o esa cosa podrá entrar aquí dentro al igual que ha entrado en las otras casas del pueblo."; 
                   
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