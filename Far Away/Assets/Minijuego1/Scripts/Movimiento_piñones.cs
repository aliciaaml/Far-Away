using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento_piñones : MonoBehaviour
{

    public Pos_correcta correcta;

    public float velocidad;

    public AudioClip sound_engranajes;
    public AudioClip sound_correcto;

    float dirY;

    public Rigidbody2D rigidbody2d1;
    public Rigidbody2D rigidbody2d2;
    public Rigidbody2D rigidbody2d3;
    public Rigidbody2D rigidbody2d4;
    public Rigidbody2D rigidbody2d5;

   
    AudioSource audioSource;


    public bool aux2;
    bool aux;

   void Start(){

        rigidbody2d1= GetComponent<Rigidbody2D>();

        audioSource= GetComponent<AudioSource>();
        aux2=false;
        aux=false;
       
   }
    void Update(){

        dirY=Input.GetAxis("Vertical");
        Arrows(rigidbody2d1);

        if (correcta.colision && aux2==false){
            audioSource.Stop();
            correcta.PlaySound(sound_correcto);
            aux2=true;
        }

    }


    void Arrows(Rigidbody2D rig){
        
        if(Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.DownArrow)){
            Debug.Log("Up key was pressed.");
            
            Vector2 position=rig.position;
            position.y=position.y+velocidad*dirY;

            rigidbody2d1.MovePosition(position);

            if (aux==false)
                audioSource.PlayOneShot(sound_engranajes);
                aux=true;
        }
     
    }
}
