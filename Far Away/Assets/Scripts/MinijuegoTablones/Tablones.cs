using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tablones : MonoBehaviour
{ 
    public SpriteRenderer Tablon;
    public static int contador;

    public GameObject TrozoNota;
    //public GameObject DialogoTrozoNota;
    public GameObject Dialogo;

    [SerializeField] private GameObject[] tablones;
    [SerializeField] private GameObject mesa;
    [SerializeField] private GameObject silla;
    [SerializeField] private Timer timer;

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
        if (!mesa.activeSelf && !silla.activeSelf && timer.timerIsRunning)
        {
            // Posici�n del rat�n

            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            MousePos.z = 0;     // Ya que las coordenadas de z son -10 por defecto y el valor del input del raton es un vector3

            // Cmporbar si esta cerca de algun cable para hacer un snap

            Collider2D[] colliders = Physics2D.OverlapCircleAll(MousePos, 0.2f);

            foreach (Collider2D collider in colliders)
            {
                if (collider.transform.parent.parent.name.Equals("PosicionesCorrectasVentana") && gameObject.transform.parent.parent.name.Equals("SpritesVentana"))
                {
                    UpdateWire(collider.transform.position);    // Actualiza la posici�n al collider adecuado

                    contador += 1;

                    Destroy(gameObject.GetComponent<Tablones>());
                    Destroy(collider);

                    if (contador == 8)
                    {
                        Debug.Log("Minijuego completado1");
                        TrozoNota.SetActive(true);
                        //DialogoTrozoNota.SetActive(true);
                        Dialogo.SetActive(true);
                        timer.timerIsRunning = false;
                        //SceneManager.LoadScene("final");
                    }


                    return;                                     // Para que el UpdateWire de abajo no se ejecute
                }

                else if (collider.transform.parent.parent.name.Equals("PosicionesCorrectasPuerta") && gameObject.transform.parent.parent.name.Equals("SpritesPuerta"))
                {
                    UpdateWire(collider.transform.position);    // Actualiza la posici�n al collider adecuado

                    contador += 1;

                    Destroy(gameObject.GetComponent<Tablones>());
                    Destroy(collider);

                    if (contador == 8)
                    {
                        /////////////////////////////////////////
                        
                        Debug.Log("Minijuego completado2");
                        timer.timerIsRunning = false;
                        TrozoNota.SetActive(true);
                        //DialogoTrozoNota.SetActive(true);
                        Dialogo.SetActive(true);
                        //SceneManager.LoadScene("final");
                    }

                    return;                                     // Para que el UpdateWire de abajo no se ejecute
                }

            }

            UpdateWire(MousePos);
        }
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
