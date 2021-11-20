using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDrag()
    {
        // Posición del ratón

        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = 0;     // yq que las coordenadas de z son -10 por defecto y el valor del input del raton es un vector3

        // Actuaizar posición del objeto

        gameObject.transform.position = MousePos;
    }
}
