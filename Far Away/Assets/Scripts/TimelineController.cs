using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public GameObject shadow;
    private bool playingCutsene = false;
    private float tiempo_start = 0;
    public float tiempo_end;


   private void OnTriggerEnter2D(Collider2D collision){
       if(collision.gameObject.tag == "Player"){
           playableDirector.Play();
           shadow.SetActive(true); 
           playingCutsene = true;       
       }
   }

   void Update(){
       if(playingCutsene){
            tiempo_start += Time.deltaTime;
            if(tiempo_start >= tiempo_end){
                shadow.SetActive(false);
                this.gameObject.SetActive(false);
                playingCutsene = false;
            }           
       }
   }
}
