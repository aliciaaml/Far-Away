using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar : MonoBehaviour
{
    public GameObject dialogo2;
    
    // Update is called once per frame
    void Update()
    {
        if(NoDistroy.no_rep){
            if(dialogo2.activeInHierarchy==false)
                dialogo2.SetActive(true);
        }
    }
}
