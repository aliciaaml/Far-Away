using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameExit : MonoBehaviour
{
    public GameObject tile;
    public GameObject exit;

    private void OnMouseDown()
    {
        tile.SetActive(false);
        exit.SetActive(false);
    }
}
