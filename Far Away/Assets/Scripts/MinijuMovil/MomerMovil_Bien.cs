using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MomerMovil_Bien : MonoBehaviour, IDragHandler
{

     public Image Imagen;
     Rigidbody2D rigidbody2d;

    public GameObject completado;
    public GameObject boton_salir;

    bool terminado;

    // Start is called before the first frame update
    void Start()
    {
        terminado=false;
        Imagen= GameObject.Find("Movil").GetComponent<Image>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void OnDrag(PointerEventData data){

       
        
        if (terminado==false){
            
             Vector2 position = rigidbody2d.position;
        
            position=data.position;

            rigidbody2d.MovePosition(position);

        }
            
    }

    private void OnTriggerEnter2D(Collider2D collision)   //inicio de interaccion con puertas (Repetir para cada puerta con otro tag y bool ambos void)
    {
        if (collision.gameObject.tag == "Poca")
        {
            Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_1raya");
        }

        if (collision.gameObject.tag == "Media")
        {
            Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_3rayas");
        }
        if (collision.gameObject.tag == "Completa")
        {
            Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_5rayas");
            completado.SetActive(true);
            boton_salir.SetActive(true);
            terminado=true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Poca")
        {
            Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_sin_senal");
        }

        if (collision.gameObject.tag == "Media")
        {
            Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_1raya");
        }

    }   
}
