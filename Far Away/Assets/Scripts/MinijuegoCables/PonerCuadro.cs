using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonerCuadro : MonoBehaviour
{
    public GameObject cuadro;

    private void OnMouseDown()
    {
        cuadro.SetActive(true);
    }
}
