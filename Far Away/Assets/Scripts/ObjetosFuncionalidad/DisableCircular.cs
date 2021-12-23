using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCircular : MonoBehaviour
{

    public GameObject circular;
    public GameObject CircularDialogo;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        circular.SetActive(false);
        CircularDialogo.SetActive(false);
    }
}
