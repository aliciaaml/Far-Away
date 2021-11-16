using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextExit : MonoBehaviour
{
    public GameObject leer;

    private void OnMouseDown()
    {
        leer.SetActive(false);
    }
}
