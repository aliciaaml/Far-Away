using UnityEngine;

public class Tablones : MonoBehaviour
{ 
    public SpriteRenderer Tablon;
    public static int contador;
    [SerializeField] private GameObject[] tablones;
    [SerializeField] private GameObject mesa;
    [SerializeField] private GameObject silla;

    Vector3 StartPos;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = gameObject.transform.position;

        contador = 0;
    }

    // Update is called once per frame
    void OnMouseDrag()
    {
        // Posición del ratón

        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = 0;     // Ya que las coordenadas de z son -10 por defecto y el valor del input del raton es un vector3

        // Cmporbar si esta cerca de algun cable para hacer un snap

        Collider2D[] colliders = Physics2D.OverlapCircleAll(MousePos, 0.2f);

        if (!mesa.activeSelf && !silla.activeSelf)
        {
            foreach (Collider2D collider in colliders)
            {
                if (collider.transform.parent.parent.name.Equals("PosicionesCorrectasVentana") && gameObject.transform.parent.parent.name.Equals("SpritesVentana"))
                {
                    UpdateWire(collider.transform.position);    // Actualiza la posición al collider adecuado

                    contador += 1;

                    Destroy(gameObject.GetComponent<Tablones>());
                    Destroy(collider);

                    if (contador == 8)
                    {
                        Debug.Log("Minijuego completado");
                    }


                    return;                                     // Para que el UpdateWire de abajo no se ejecute
                }

                else if (collider.transform.parent.parent.name.Equals("PosicionesCorrectasPuerta") && gameObject.transform.parent.parent.name.Equals("SpritesPuerta"))
                {
                    UpdateWire(collider.transform.position);    // Actualiza la posición al collider adecuado

                    contador += 1;

                    Destroy(gameObject.GetComponent<Tablones>());
                    Destroy(collider);

                    if (contador == 8)
                    {
                        Debug.Log("Minijuego completado");
                    }


                    return;                                     // Para que el UpdateWire de abajo no se ejecute
                }

            }

            UpdateWire(MousePos);
        }
        

    }

    
    private void OnMouseUp()
    {
        // Reseteamos la posición del ratón al levantar

        UpdateWire(StartPos);
    } 
    

    void UpdateWire(Vector3 MousePos)
    {
        // Actuaizar posición del objeto
        gameObject.transform.position = MousePos;
    }
}
