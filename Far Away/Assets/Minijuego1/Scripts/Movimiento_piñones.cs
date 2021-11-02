using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movimiento_piñones : MonoBehaviour, IDragHandler
{
   

    Vector3 mousePosition;

    public Pos_correcta correcta;

    public AudioClip sound_engranajes;
    public AudioClip sound_correcto;

    public GameObject piñon;

    AudioSource audioSource;

    bool aux;
    public bool aux2;

   

    void Start(){

        audioSource= GetComponent<AudioSource>();
        aux=false;
        aux2=false;


    }

    void Update(){

        if (Input.anyKey && aux==false){

            audioSource.PlayOneShot(sound_engranajes);
            aux=true;
        }
        if (correcta.colision && aux2==false){
            audioSource.Stop();
            correcta.PlaySound(sound_correcto);
            aux2=true;
        }

    }

    public void OnDrag(PointerEventData eventData){

        mousePosition= Input.mousePosition;
        mousePosition.z=1;
        mousePosition.x=263;

        Debug.Log(Input.mouseScrollDelta);

        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

    }

    

}
