using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncontrarSeñal : MonoBehaviour
{

    public Image Imagen;

    public Collider2D Señal;


    void Start(){
        
        Imagen= GameObject.Find("Movil").GetComponent<Image>();
    }


    void Update(){

        if(MonoBehaviour.OnTriggerEnter2D(Collider2D Señal)){

            Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_con_señal");
            Debug.Log("SEÑAL");

        }
        else {

            Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_sin_señal");
            Debug.Log("NO SEÑAL");
        }
                
      

    }
    /*void OnTriggerEnter2D(Collider2D coll){
 
            
            colision+=1;

            if(señal==false){
                Imagen.sprite= Resources.Load<Sprite>("Sprites/movil_con_señal");
                señal=true;
                colision=0;
                Debug.Log("SEÑAL");
            }      
            
    }*/
}
