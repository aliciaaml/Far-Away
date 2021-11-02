using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pos_correcta : MonoBehaviour
{
    public bool colision;
    AudioSource audioSource;

    

    void Start() {

        audioSource= GetComponent<AudioSource>();
        colision=false;
    }

   public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

     void OnTriggerEnter2D(Collider2D other){
         
        Movimiento_piñones controller = other.GetComponent<Movimiento_piñones>();

        controller.aux2=false;        
      

        if(other.gameObject.tag=="piñon")
            colision=true;
    
    }

 
 
}
