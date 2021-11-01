using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movimiento_piñones : MonoBehaviour, IDragHandler
{
   

    Vector3 mousePosition;

    public Pos_correcta correcta;

    public AudioClip sound_engranajes;

    AudioSource audioSource;

    Vector3 aux= new Vector3 (0,0,0);

    void Start(){

        audioSource= GetComponent<AudioSource>();

    }

    void Update(){

        if (Input.anyKey && correcta.colision==false){

            audioSource.PlayOneShot(sound_engranajes);
        }
        else audioSource.Stop();
    }

    public void OnDrag(PointerEventData eventData){

        mousePosition= Input.mousePosition;
        mousePosition.z=1;
        mousePosition.x=263;


        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
        
    
    

}
