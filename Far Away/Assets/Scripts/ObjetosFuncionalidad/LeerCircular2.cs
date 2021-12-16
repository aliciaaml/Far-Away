using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeerCircular2 : MonoBehaviour
{

    public GameObject leer_circular;
    public GameObject boton_circular;
    // Start is called before the first frame update

    void Update(){
        if(ControlDeDialogo.circular){
            leer_circular.SetActive(true);
            boton_circular.SetActive(true);
        }
    }
        
}
