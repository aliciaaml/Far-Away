using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPasar : MonoBehaviour
{

    public GameObject dialogoCasa4;
    public NoPasarDialog reloj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w")){
            if(PlayerController.no_casa4){
                dialogoCasa4.SetActive(true);
                StartCoroutine(reloj.Reloj());
                
            }
        }
    }
}
