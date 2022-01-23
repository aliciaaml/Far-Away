using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeerTrozosNota : MonoBehaviour
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
        if(ControlDeDialogo.trozoNota){
            leer.SetActive(true);
            boton.SetActive(true);
            ControlDeDialogo.nota=false;
        }
    }
}