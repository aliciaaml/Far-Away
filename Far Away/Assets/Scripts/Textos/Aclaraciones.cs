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
        if(EsconderTexto.boton_no && !SiguienteText1.segundoTexto && !SiguienteText10.texto10)
            gameObject.SetActive(false);

        if(EsconderTexto.boton_no && SiguienteText1.segundoTexto && EsconderTexto.num_textos==2)
            gameObject.SetActive(false);

        if(EsconderTexto.boton_no && SiguienteText10.texto10 && EsconderTexto.num_textos==3)
            gameObject.SetActive(false);
    }
}
