using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsconderCuadro : MonoBehaviour
{
    //public GameObject cuadro;
    public GameObject texto1;
    public GameObject texto2;

    private void OnMouseDown()
    {
        //cuadro.SetActive(false);
        texto1.SetActive(false);
        texto2.SetActive(false);
    }
}
