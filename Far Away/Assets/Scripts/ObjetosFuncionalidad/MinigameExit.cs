using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameExit : MonoBehaviour
{
    public GameObject tile;
    public GameObject exit;
    public GameObject boton;
    public GameObject flecha_salida;
    public GameObject boton_exit;

    private void OnMouseDown()
    {
        tile.SetActive(false);
        exit.SetActive(false);
        boton.SetActive(false);
        boton_exit.SetActive(false);
        flecha_salida.SetActive(true);
        MinigameEnter.circularDisable=false;
    }
}
