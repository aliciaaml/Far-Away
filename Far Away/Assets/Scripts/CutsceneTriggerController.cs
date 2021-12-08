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
    
}
