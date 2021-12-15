using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoverMovil : MonoBehaviour, IDragHandler
{

     Rigidbody2D rigidbody2d;
     bool terminado;

    public Image Imagen;
    public GameObject completado;
    public GameObject boton_salir;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        Imagen= GameObject.Find("Movil").GetComponent<Image>();
        terminado=false;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)   //inicio de interaccion con puertas (Repetir para cada puerta con otro tag y bool ambos void)
    {
        if (collision.gameObject.tag == "Poca")
        {
            Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_1raya");
            terminado=true;
            completado.SetActive(true);
            boton_salir.SetActive(true);
        }


    }

    public void OnDrag(PointerEventData data){

        if(terminado==false){

            Vector2 position = rigidbody2d.position;
        
            position=data.position;

            rigidbody2d.MovePosition(position);
        }

        
    }
}
