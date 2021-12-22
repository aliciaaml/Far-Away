using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimarEntradaDialogos : MonoBehaviour
{

    Animator anim;
    //Animator salir;
    // Start is called before the first frame update
    void Start()
    {
        anim=gameObject.GetComponent<Animator>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EsconderTexto.AnimSalida){
            anim.SetTrigger("salir");
            EsconderTexto.AnimSalida=false;
        }
        
    }
}
