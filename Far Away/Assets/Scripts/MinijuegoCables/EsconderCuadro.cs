using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsconderCuadro : MonoBehaviour
{
    public GameObject cuadro;

    private void OnMouseDown()
    {
        cuadro.SetActive(false);
    }
}
