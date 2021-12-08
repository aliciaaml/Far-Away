using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncontrarSeñal : MonoBehaviour
{

    public Image Imagen;

    public GameObject completado;
    public GameObject boton_salir;


    void Start(){
        
        Imagen= GameObject.Find("Movil").GetComponent<Image>();
    }


    void Update(){

        Vector3 mousePos = Input.mousePosition;

        if((mousePos.x<154 && mousePos.x>=-42.22) && (transform.position.y>=156 && transform.position.y<218.24) ){

            Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_señal_min");
            Debug.Log("SEÑAL");

            completado.SetActive(true);
            boton_salir.SetActive(true);
            CutsceneTriggerController.instance.cutsceneTigger.SetActive(true);
        }
        else {

            Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_sin_señal");
            Debug.Log("NO SEÑAL");
        }
                 

    }
}
