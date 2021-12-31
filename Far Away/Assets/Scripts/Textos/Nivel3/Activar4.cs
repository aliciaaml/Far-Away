using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar4 : MonoBehaviour
{
    public GameObject dialogo2;
    
    // Update is called once per frame
    void Update()
    {
        if(DestroyDialoN3.no_rep1){
            if(dialogo2.activeInHierarchy==false){
                dialogo2.SetActive(true);
            }
                
    
        }
    }
}