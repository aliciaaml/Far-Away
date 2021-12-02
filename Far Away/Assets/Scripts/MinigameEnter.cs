using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameEnter : MonoBehaviour
{
    public GameObject tile;
    public GameObject exit;
    public GameObject circular;
    public GameObject flecha_salida;

    private void OnMouseDown()
    {
        tile.SetActive(true);
        exit.SetActive(true);
        circular.SetActive(false);
        flecha_salida.SetActive(false);
    }
}
