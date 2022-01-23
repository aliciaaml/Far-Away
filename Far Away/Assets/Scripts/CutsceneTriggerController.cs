using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTriggerController : MonoBehaviour
{
    public static CutsceneTriggerController instance;
    public GameObject cutsceneTigger;

    private void Awake(){
        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    void Update(){
        if(EsconderTexto.activar){
            cutsceneTigger.SetActive(true);
            EsconderTexto.activar=false;
        }
    }
    
}
