using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leer : MonoBehaviour
{
    public GameObject leer;

    private void OnMouseDown()
    {
        leer.SetActive(true);
    }
}
