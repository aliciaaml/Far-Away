using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDeDialogo : MonoBehaviour
{
    public static bool circular;
    public static bool nota;
    public static bool trozoNota;

    private readonly Queue<string> colaDialogos = new Queue<string>();          // Declaraciones de queues go brrrrrrrrrrr xd
    Textos texto;
    [SerializeField] TextMeshProUGUI textoPantalla;
    private bool running = false;
    Animator anim;

    private void Start()
    {
        circular=false;
        gameObject.SetActive(false);
        anim=gameObject.GetComponent<Animator>();
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

            if(ObjectPickUp.ciruclar_item){
                circular=true;
                ObjectPickUp.ciruclar_item=false;
            }
            
            if(ObjectPickUp.nota_item){
                nota=true;
                ObjectPickUp.nota_item=false;
            }

            if(ObjectPickUp.trozoNota_item){
                trozoNota=true;
                ObjectPickUp.trozoNota_item=false;
            }
            
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
        anim.SetTrigger("salir");
        StartCoroutine(Transiciona());
        
    }


    IEnumerator Transiciona()
    {   
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        
    }
}
