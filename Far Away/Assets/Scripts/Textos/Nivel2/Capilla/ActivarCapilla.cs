using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCapilla : MonoBehaviour
{
    public GameObject dialogo2;
    
    // Update is called once per frame
    void Update()
    {
        if(DestroyDialoCap.no_repCap){
            if(dialogo2.activeInHierarchy==false){
                dialogo2.SetActive(true);
            }
                
    
        }
    }
}
