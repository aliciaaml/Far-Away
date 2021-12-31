using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarComun : MonoBehaviour
{
    public GameObject dialogo2;
    
    // Update is called once per frame
    void Update()
    {
        if(DestroyDialogoComun.no_rep2){
            if(dialogo2.activeInHierarchy==false){
                dialogo2.SetActive(true);
            }
                
    
        }
    }
}
