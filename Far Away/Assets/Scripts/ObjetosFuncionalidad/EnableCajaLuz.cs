using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCajaLuz : MonoBehaviour
{
  public GameObject cuadroLuz;
    // Start is called before the first frame update
 
    private void OnMouseDown()
    {
        cuadroLuz.SetActive(true);
    }
}
