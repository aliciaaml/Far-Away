using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeerTrozosNota : MonoBehaviour
{
    public GameObject leer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ControlDeDialogo.trozoNota){
            leer.SetActive(true);
            ControlDeDialogo.nota=false;
        }
    }
}