using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto1Casa2 : MonoBehaviour
{
    string frase = "La puerta está abierta, pero no hay nadie... \n"+
                    "Esto es muy raro. ";
                   
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