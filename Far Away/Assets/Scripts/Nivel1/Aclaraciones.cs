using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aclaraciones : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EsconderTexto.boton_no)
            gameObject.SetActive(false);
    }
}
