using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablingCirucular : MonoBehaviour
{
    public GameObject circular;
    // Start is called before the first frame update
 
    private void OnMouseDown()
    {
        circular.SetActive(false);
    }
}
