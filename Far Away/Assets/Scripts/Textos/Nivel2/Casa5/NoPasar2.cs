using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPasar2 : MonoBehaviour
{

    public NoPasar2Dialog reloj;
    public GameObject dialogoCasa5;


    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w")){

            if(PlayerController.no_puertaCura){  //Si no he pasado por la iglesia y estoy en colisión con la puerta 2
                dialogoCasa5.SetActive(true);
                StartCoroutine(reloj.Reloj());
                
      
            }

        }
   
    }
    
}
