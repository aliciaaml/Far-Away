using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Activar2 : MonoBehaviour
{
    public GameObject dialogo2;

    public GameObject dialogoFinal1;
    
    // Update is called once per frame
    void Update()
    {
        if(DestroyDialoN1.no_rep1){
            if(dialogo2.activeInHierarchy==false){
                dialogo2.SetActive(true);
            }
                
    
        }

        if(DestroyDialoN1.no_rep2){
            if(Inventory.contador==6 && SceneManager.GetActiveScene().name=="Nivel1Exterior"){
                dialogoFinal1.SetActive(true);
                DestroyDialoN1.no_rep2=false;
            }
        }
            
                
    }
}
