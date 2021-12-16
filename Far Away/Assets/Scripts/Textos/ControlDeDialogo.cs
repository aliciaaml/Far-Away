using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDeDialogo : MonoBehaviour
{
    

    public static bool circular;

    private readonly Queue<string> colaDialogos = new Queue<string>();          // Declaraciones de queues go brrrrrrrrrrr xd
    Textos texto;
    [SerializeField] TextMeshProUGUI textoPantalla;
    private bool running = false;

    private void Start()
    {
        gameObject.SetActive(false);
        circular=false;
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
        if (colaDialogos.Count == 0 && !running)
        {
            CierraCuadro();
            circular=true;
            return;
        }

        if (!running)
        {
            string fraseActual = colaDialogos.Dequeue();
            textoPantalla.text = fraseActual;
            StartCoroutine(MostrarCaracteres(fraseActual));
            
        }
        
    }

    IEnumerator MostrarCaracteres (string textoAMostrar)
    {
        running = true;
        textoPantalla.text = "";
        foreach (char caracter in textoAMostrar.ToCharArray())
        {
            textoPantalla.text += caracter;
            yield return new WaitForSeconds(0.02f);
        }
        running = false;
    }

    void CierraCuadro()
    {
        gameObject.SetActive(false);
    }
}
