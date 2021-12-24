using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapaDialogoNivel2 : MonoBehaviour
{
    string frase = "Aún no es momento de ir al nivel 2, me faltan cosas por hacer aquí.";
                   
    public Text dialogo;
    

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Reloj());
    }
    
    public IEnumerator Reloj()
    {
        dialogo.text="";
        EsconderTexto.run=true;
        foreach (char caracter in frase)
        {
            dialogo.text = dialogo.text + caracter;
            yield return new WaitForSeconds(0.07f);
        }
        EsconderTexto.run=false;
    }
}