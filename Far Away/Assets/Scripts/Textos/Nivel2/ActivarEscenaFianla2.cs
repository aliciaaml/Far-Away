using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivarEscenaFianla2 : MonoBehaviour
{
   public GameObject dialogo4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Inventory.contador  + "  numero de items");

        if(Inventory.contador==4 && SceneManager.GetActiveScene().name=="Nivel2Exterior" && DestroyDialogC4.casa4 && TextoMovil.movil1terminado){
            dialogo4.SetActive(true);
            DestroyDialoN2.unavez=false;
        }
        
        
    }
}