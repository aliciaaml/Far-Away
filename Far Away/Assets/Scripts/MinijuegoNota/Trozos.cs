using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trozos : MonoBehaviour
{
    [SerializeField] private GameObject trozo1;
    [SerializeField] private GameObject trozo2;

    Vector3 StartPos;

    public static int contador;
    public GameObject Dialogo;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = gameObject.transform.position;

        contador = 0;
    }

    private void OnMouseDrag()
    {
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = 0;     // Ya que las coordenadas de z son -10 por defecto y el valor del input del raton es un vector3

        // Cmporbar si esta cerca de algun cable para hacer un snap

        Collider2D[] colliders = Physics2D.OverlapCircleAll(MousePos, 0.2f);// Cmporbar si esta cerca de algun cable para hacer un snap

        foreach (Collider2D collider in colliders)
        {
            if ((gameObject.transform.name.Equals("Trozo1")) && collider.transform.name.Equals("Place1"))
            {
                UpdateWire(collider.transform.position);    // Actualiza la posici�n al collider adecuado

                contador += 1;

                Destroy(gameObject.GetComponent<Trozos>());

                if (contador == 2)
                {
                    Debug.Log("Minijuego completado1");
                    Dialogo.SetActive(true);

                }

                return;                                     // Para que el UpdateWire de abajo no se ejecute
            }

            if ((gameObject.transform.name.Equals("Trozo2")) && collider.transform.name.Equals("Place2"))
            {
                UpdateWire(collider.transform.position);    // Actualiza la posici�n al collider adecuado

                contador += 1;

                Destroy(gameObject.GetComponent<Trozos>());

                if (contador == 2)
                {
                    Debug.Log("Minijuego completado2");
                    Dialogo.SetActive(true);
                    //SceneManager.LoadScene("final");
                }

                return;                                     // Para que el UpdateWire de abajo no se ejecute
            }
        }

        UpdateWire(MousePos);
    }

    private void OnMouseUp()
    {
        // Reseteamos la posici�n del rat�n al levantar

        UpdateWire(StartPos);
    }


    void UpdateWire(Vector3 MousePos)
    {
        // Actuaizar posici�n del objeto
        gameObject.transform.position = MousePos;
    }

}
