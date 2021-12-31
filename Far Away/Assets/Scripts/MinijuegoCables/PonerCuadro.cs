using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonerCuadro : MonoBehaviour
{
   // public GameObject cuadro;
    public GameObject texto1;
    public GameObject texto2;

    private void OnMouseDown()
    {
        //cuadro.SetActive(true);
        texto1.SetActive(true);
        texto2.SetActive(true);
    }
}
