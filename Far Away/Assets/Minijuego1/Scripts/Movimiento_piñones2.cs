using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movimiento_piñones2 : MonoBehaviour, IDragHandler
{
   

    Vector3 mousePosition;

    public Pos_correcta2 correcta;

    public AudioClip sound_engranajes;
    public AudioClip sound_correcto;


    AudioSource audioSource;

    bool aux;
    public bool aux2;

   

    void Start(){

        audioSource= GetComponent<AudioSource>();
        aux=false;
        aux2=false;


    }

    void Update(){

        if (Input.anyKey && aux==false &&  mousePosition.x==280){

            audioSource.PlayOneShot(sound_engranajes);
            aux=true;
        }
        if (correcta.colision && aux2==false &&  mousePosition.x==280){
            audioSource.Stop();
            correcta.PlaySound(sound_correcto);
            aux2=true;
        }

    }

    public void OnDrag(PointerEventData eventData){

        mousePosition= Input.mousePosition;
        mousePosition.z=1;
        mousePosition.x=280;


        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

    }

    

}
