using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeerNotaVecino : MonoBehaviour
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
        if(ObjectPickUp.nota_item){
            leer.SetActive(true);
            boton.SetActive(true);
            ObjectPickUp.nota_item=false;
        }
    }
}
