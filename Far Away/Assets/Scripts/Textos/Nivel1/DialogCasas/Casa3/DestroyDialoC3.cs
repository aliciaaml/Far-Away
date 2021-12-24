using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDialoC3 : MonoBehaviour
{
    public static DestroyDialoC3 inst;        //singleton (se encarga de que solo haya una instancia y que no se duplique)
                                        //es una clase que se ocupa de que unicamente haya una instancia de esa clase
                                        //pero que ademas se pueda acceder desde cualquier lugar

    public static bool no_rep3=true;

    void Awake(){


        if(DestroyDialoC3.inst==null ){
            //primera vez. Por lo que esta es la instancia
            DestroyDialoC3.inst = this;
            no_rep3=true;
            EsconderTexto.boton_no=false;

            DontDestroyOnLoad(gameObject);          //Se crea una nueva escena que no se 
                                                //destruye nunca y mete el objeto en ella
            
        }
        
        else{
            //ya hay una instancia.Eliminar esta
            Destroy(gameObject);
            no_rep3=false;

        }

    }
}