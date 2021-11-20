using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wire : MonoBehaviour
{
    public SpriteRenderer WireEnd;

    Vector3 StartParentPos;
    Vector3 StartPos;

    // Start is called before the first frame update
    void Start()
    {
        StartParentPos = gameObject.transform.parent.position;
        StartPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void OnMouseDrag()
    {
        // Posición del ratón

        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = 0;     // Ya que las coordenadas de z son -10 por defecto y el valor del input del raton es un vector3

        UpdateWire(MousePos);
        
    }

    private void OnMouseUp()
    {
        
    }

    void UpdateWire(Vector3 MousePos)
    {
        // Actuaizar posición del objeto

        gameObject.transform.position = MousePos;

        // Actualizar dirección

        Vector3 Direction = MousePos - StartParentPos;
        gameObject.transform.right = Direction * transform.lossyScale.x;        // Como usamos un cambio de escala para la parte derecha, transfrom.lossyScale hace que las coordenadas en este caso de rotación sean correctas


        // Actualizar escala

        float dist = Vector2.Distance(StartParentPos, MousePos);
        WireEnd.size = new Vector2(dist, WireEnd.size.y);
    }
}
