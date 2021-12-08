using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
   public PlayableDirector playableDirector;
   public GameObject shadow;

   public void Play(){
       playableDirector.Play();
   }

   private void OnTriggerEnter2D(Collider2D collision){
       if(collision.gameObject.tag == "Player"){
           Play();
           shadow.SetActive(true);
       }
   }
}
