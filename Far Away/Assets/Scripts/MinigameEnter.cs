using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameEnter : MonoBehaviour
{
    public GameObject tile;
    public GameObject exit;

    private void OnMouseDown()
    {
        tile.SetActive(true);
        exit.SetActive(true);
    }
}
