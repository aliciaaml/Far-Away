using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento_piñones5 : MonoBehaviour
{

    public Movimiento_piñones mov;

    public float velocidad;

    public AudioClip sound_engranajes;
    public AudioClip sound_correcto;

    float dirY;

    public Rigidbody2D piñon5;

    AudioSource audioSource;


    bool colis;
 
    bool aux;

    public GameObject position;

    bool terminado=false;

   void Start(){

        piñon5= GetComponent<Rigidbody2D>();

        audioSource= GetComponent<AudioSource>();
        
        aux=false;
        colis=false;
        
       
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

        if(mov.num_colis==4){

            position.name="Pos_correcta5";
            Arrows(piñon5);
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

           terminado=true;
           Debug.Log(terminado);
                
                    
        }
     
    }
}
