using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento_piñones : MonoBehaviour
{

    public float velocidad;

    public AudioClip sound_engranajes;
    public AudioClip sound_correcto;

    public GameObject Flecha;

    float dirY;

    public Rigidbody2D piñon1;

   
    AudioSource audioSource;


    bool colis;
    public int num_colis;
    bool aux;

    public GameObject position;


   void Start(){

        piñon1= GetComponent<Rigidbody2D>();

        audioSource= GetComponent<AudioSource>();

        Flecha.SetActive(true);
        
        aux=false;
        colis=false;
        num_colis=0;
        
       
   }
   void OnCollisionEnter2D (Collision2D colision){
       

       if (colision.gameObject.name==position.name){
            audioSource.Stop();
            audioSource.PlayOneShot(sound_correcto);
            colis=true;
       }
   }
    void Update(){

        dirY=Input.GetAxis("Vertical");

        if(num_colis==0){

            position.name="Pos_correcta1";
            Arrows(piñon1);
        }
            


    }


    void Arrows(Rigidbody2D rig){
        
        if(Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.DownArrow)) {

            if(colis==false){
                Vector2 position=rig.position;
                position.y=position.y+velocidad*dirY;

                rig.MovePosition(position);

                if (aux==false){

                    audioSource.PlayOneShot(sound_engranajes);
                    aux=true;
                }
                   
            }
            
            
        }
        else {
            audioSource.Stop();
            aux=false;
        }

        if(colis){

            if(Input.GetKey(KeyCode.RightArrow)){

                    num_colis=1;
                    Flecha.SetActive(false);

                    
            }
                
                    
        }
     
    }
}
