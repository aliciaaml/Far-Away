using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCasa5 : MonoBehaviour
{
    public GameObject dialogo2;
    
    // Update is called once per frame
    void Update()
    {
        if(DestroyDialoC5.no_rep5){
            if(dialogo2.activeInHierarchy==false){
                dialogo2.SetActive(true);
            }
                
    
        }
    }
}
