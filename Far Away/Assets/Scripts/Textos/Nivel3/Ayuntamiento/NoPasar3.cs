using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoPasar3 : MonoBehaviour
{

    public DialogoAyuntamiento reloj;
    

    public GameObject dialogoAyuntamiento;

    


    

    //public PlayerController personaje;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w")){

            if(!PlayerController.desbloq_ayuntamiento && PlayerController.colion_ayuntamiento){

                dialogoAyuntamiento.SetActive(true);
                StartCoroutine(reloj.Reloj());
                
            }

        }
   
    }

    
    
}
