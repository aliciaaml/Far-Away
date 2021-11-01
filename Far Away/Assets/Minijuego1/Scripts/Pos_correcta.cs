using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pos_correcta : MonoBehaviour
{
    public bool colision;

    public AudioClip sound_correcto;

     void OnTriggerEnter2D(Collider2D other){
         
        Movimiento_piñones controller = other.GetComponent<Movimiento_piñones>();

        controller.PlaySound(sound_correcto);        
      

        if(other.gameObject.tag=="piñon")
            colision=true;
    
        else colision=false;
    }

 
    
}
