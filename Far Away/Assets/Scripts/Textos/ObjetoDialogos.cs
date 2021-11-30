using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoDialogos : MonoBehaviour
{
    public Textos textos;

    private void OnMouseDown()
    {
        FindObjectOfType<ControlDeDialogo>().ActivarCuadro(textos);
        FindObjectOfType<ControlDeDialogo>().ActivarTexto();
    }
}
