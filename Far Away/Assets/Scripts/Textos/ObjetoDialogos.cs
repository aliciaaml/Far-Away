using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoDialogos : MonoBehaviour
{
    public Textos textos;
    [SerializeField] ControlDeDialogo control;

    private void OnMouseDown()
    {
        control.ActivarCuadro(textos);
    }
}
