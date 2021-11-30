using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDeDialogo : MonoBehaviour
{
    private Queue<string> colaDialogos;
    Textos texto;
    [SerializeField] TextMeshProUGUI textoPantalla;
    
    public void ActivarCuadro(Textos textoObj)
    {
        texto = textoObj;
    }

    public void ActivarTexto()
    {
        colaDialogos.Clear();
        foreach (string textoGuardado in texto.arrayTextos)
        {
            colaDialogos.Enqueue(textoGuardado);
        }
        Siguiente();
    }

    public void Siguiente()
    {
        if (colaDialogos.Count == 0)
        {
            CierraCuadro();
            return;
        }

        string fraseActual = colaDialogos.Dequeue();
        textoPantalla.text = fraseActual;
    }

    void CierraCuadro()
    {
        gameObject.SetActive(false);
    }
}
