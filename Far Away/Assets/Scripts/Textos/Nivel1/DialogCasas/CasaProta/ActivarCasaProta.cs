using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCasaProta : MonoBehaviour
{
    public GameObject dialogo2;
    
    // Update is called once per frame
    void Update()
    {
        if(DestroyDialogCasaProta.no_repProta){
            if(dialogo2.activeInHierarchy==false){
                dialogo2.SetActive(true);
            }
                
    
        }
    }
}
