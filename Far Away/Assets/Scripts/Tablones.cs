using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablones : MonoBehaviour
{ 
    public SpriteRenderer Tablon;
    public static int contador;

    [SerializeField] private GameObject[] tablones;

    Vector3 StartParentPos;
    Vector3 StartPos;

    // Start is called before the first frame update
    void Start()
    {
        StartParentPos = gameObject.transform.parent.position;
        StartPos = gameObject.transform.position;

        contador = 0;
    }


    void OnMouseDrag()
    {
        // Posici�n del rat�n

        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = 0;     // Ya que las coordenadas de z son -10 por defecto y el valor del input del raton es un vector3

        // Cmporbar si esta cerca de algun tablon para hacer un snap

        Collider2D[] colliders = Physics2D.OverlapCircleAll(MousePos, 0.2f);
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject != gameObject)          // comprueba que el collider no pertenece al gameobject
            {
                UpdateWire(collider.transform.position);    // Actualiza la posici�n al collider adecuado

                if (collider.transform.position == gameObject.transform.position)      // Se comprueba que colisiona con el color adecuado
                {

                    contador += 1;

                    Destroy(gameObject.GetComponent<Tablones>());

                    if (contador == 8)
                    {
                        Debug.Log("Minijuego completado");
                    }
                }

                return;                                     // Para que el UpdateWire de abajo no se ejecute
            }
        }

        UpdateWire(MousePos);

    }
    /*
    private void OnMouseUp()
    {
        // Reseteamos la posici�n del rat�n al levantar

        UpdateWire(StartPos);
    } 
    */

    void UpdateWire(Vector3 MousePos)
    {
        // Actuaizar posici�n del objeto

        gameObject.transform.position = MousePos;
    }
}
