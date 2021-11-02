using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pos_correcta4 : MonoBehaviour
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
         
        Movimiento_piñones4 controller = other.GetComponent<Movimiento_piñones4>();

        controller.aux2=false;        
      

        if(other.gameObject.tag=="piñon")
            colision=true;
    
    }

 
 
}
