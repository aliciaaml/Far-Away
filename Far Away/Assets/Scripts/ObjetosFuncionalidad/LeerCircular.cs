using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeerCircular : MonoBehaviour
{
    public GameObject leer;
    public GameObject boton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ControlDeDialogo.circular){
            leer.SetActive(true);
            boton.SetActive(true);
            ControlDeDialogo.circular=false;
        }
    }
}
