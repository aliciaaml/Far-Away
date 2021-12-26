using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameExit : MonoBehaviour
{
    public GameObject tile;
    public GameObject exit;
    public GameObject flecha_salida;
    public GameObject radio;
    public GameObject boton_exit;

    private void OnMouseDown()
    {
        tile.SetActive(false);
        exit.SetActive(false);
        boton_exit.SetActive(false);
        radio.SetActive(true);
        flecha_salida.SetActive(true);
        MinigameEnter.circularDisable=false;
    }
}
