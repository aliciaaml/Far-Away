using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aclaraciones : MonoBehaviour
{

    public static bool aclar;

    // Start is called before the first frame update
    void Start()
    {
        aclar=true;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log(EsconderTexto.boton_no);
        Debug.Log(SiguienteTextoAux.textaux);
        Debug.Log(SiguienteText1.texto1);
        Debug.Log(SiguienteText2.texto2);
        Debug.Log(SiguienteText3.texto3);
        Debug.Log(SiguienteTexto4.texto4);
       */
        if(EsconderTexto.boton_no && !SiguienteTextoAux.textaux &&!SiguienteText1.texto1 && !SiguienteText2.texto2  && !SiguienteText3.texto3 && !SiguienteTexto4.texto4){

            gameObject.SetActive(false);
            EsconderTexto.num_textos=0;

        }


        if(EsconderTexto.boton_no && SiguienteText1.texto1 && EsconderTexto.num_textos==2){

            gameObject.SetActive(false);
            EsconderTexto.num_textos=0;
            SiguienteText1.texto1=false;
        }
           

        if(EsconderTexto.boton_no && SiguienteText2.texto2 && EsconderTexto.num_textos==3){

            gameObject.SetActive(false);
            EsconderTexto.num_textos=0;
            SiguienteText2.texto2=false;
        }
           

        if(EsconderTexto.boton_no && SiguienteText3.texto3 && EsconderTexto.num_textos==4){

            gameObject.SetActive(false);
            EsconderTexto.num_textos=0;
            SiguienteText3.texto3=false;
        }

        if(EsconderTexto.boton_no && SiguienteTexto4.texto4 && EsconderTexto.num_textos==5){

            gameObject.SetActive(false);
            EsconderTexto.num_textos=0;
             SiguienteTexto4.texto4=false;
        }
    }
}
