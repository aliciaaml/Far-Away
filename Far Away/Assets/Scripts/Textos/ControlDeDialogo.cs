using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDeDialogo : MonoBehaviour
{
    private readonly Queue<string> colaDialogos = new Queue<string>();          // Declaraciones de queues go brrrrrrrrrrr xd
    Textos texto;
    [SerializeField] TextMeshProUGUI textoPantalla;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void ActivarCuadro(Textos textoObj)
    {
        gameObject.SetActive(true);
        texto = textoObj;
        ActivarTexto();
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
