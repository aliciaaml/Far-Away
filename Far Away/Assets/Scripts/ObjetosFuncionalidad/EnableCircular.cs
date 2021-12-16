using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCircular : MonoBehaviour
{
      public GameObject circular;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        circular.SetActive(true);
    }
}
