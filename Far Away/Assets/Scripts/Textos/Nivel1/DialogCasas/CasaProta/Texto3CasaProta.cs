using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto3CasaProta : MonoBehaviour
{
    string frase = "De esa manera esa cosa seguro que no puedrá entrar.\n"+
                    "O almenos espero que sirva hasta que vengan a ayudarme..\n"+
                    "Debo darme prisa, mi tiempo se acaba."   ; 
                   
    public Text dialogo;
    
    public Timer time;

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
        time.timerIsRunning=true;
    }
}