using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCasa4 : MonoBehaviour
{
    public GameObject dialogo2;
    
    // Update is called once per frame
    void Update()
    {
        if(DestroyDialogC4.no_rep4){
            if(dialogo2.activeInHierarchy==false){
                dialogo2.SetActive(true);
            }
                
    
        }
    }
}
