using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    Vector3 StartPos;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = gameObject.transform.parent.position;
    }

    // Update is called once per frame
    void OnMouseDrag()
    {
        // Posici�n del rat�n

        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = 0;     // yq que las coordenadas de z son -10 por defecto y el valor del input del raton es un vector3

        // Actuaizar posici�n del objeto

        gameObject.transform.position = MousePos;

        // Actualizar direcci�n

        Vector3 Direction = MousePos - StartPos;
        gameObject.transform.right = Direction;
    }
}
