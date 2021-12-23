using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCasa3 : MonoBehaviour
{
    public GameObject dialogo2;
    
    // Update is called once per frame
    void Update()
    {
        if(DestroyDialoC3.no_rep3){
            if(dialogo2.activeInHierarchy==false){
                dialogo2.SetActive(true);
            }
                
    
        }
    }
}
