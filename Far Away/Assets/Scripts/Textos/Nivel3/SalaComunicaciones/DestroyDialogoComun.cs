using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDialogoComun : MonoBehaviour
{
    public static DestroyDialogoComun inst;        //singleton (se encarga de que solo haya una instancia y que no se duplique)
                                        //es una clase que se ocupa de que unicamente haya una instancia de esa clase
                                        //pero que ademas se pueda acceder desde cualquier lugar

    public static bool no_rep2=true;

    

    void Awake(){


        if(DestroyDialogoComun.inst==null ){
            //primera vez. Por lo que esta es la instancia
            DestroyDialogoComun.inst = this;
            no_rep2=true;
            EsconderTexto.boton_no=false;

  

            DontDestroyOnLoad(gameObject);          //Se crea una nueva escena que no se 
                                                //destruye nunca y mete el objeto en ella
            
        }
        
        else{
            //ya hay una instancia.Eliminar esta
            Destroy(gameObject);
            no_rep2=false;

        }

    }

    
}