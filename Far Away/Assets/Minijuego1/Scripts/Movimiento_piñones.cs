using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movimiento_piñones : MonoBehaviour, IDragHandler
{
    //int done=0;
    //bool terminado=false;
    
   //public GameObject piñon;
    

    //Vector2 position = piñon.position;


    AudioSource audioSource;

    Vector3 mousePosition;
    


    public AudioClip sound_correcto;

    //public AudioClip sound_engranajes;

    public void OnDrag(PointerEventData eventData){

        mousePosition= Input.mousePosition;
        mousePosition.z=1;
        mousePosition.x=263;

       

        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        //audioSource.PlayOneShot(sound_engranajes);
    }


    void Start(){
         audioSource= GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        play_sound();
    }


    
    public void play_sound(){


        if (mousePosition.y== 200){
        
            //audioSource.Stop(sound_engranajes);
            audioSource.PlayOneShot(sound_correcto);
            //done+=1;
        }

  
        
    }

   
    

}
