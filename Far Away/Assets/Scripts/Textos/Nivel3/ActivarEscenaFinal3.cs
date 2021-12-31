using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivarEscenaFinal3 : MonoBehaviour
{
   public GameObject dialogo4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Inventory.contador==6 && SceneManager.GetActiveScene().name=="Nivel3Exterior" && MomerMovil_Bien.dialogoactivar){
            dialogo4.SetActive(true);
        }
        
        
    }
}