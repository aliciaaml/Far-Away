using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDialogC4 : MonoBehaviour
{
    public static DestroyDialogC4 inst;        //singleton (se encarga de que solo haya una instancia y que no se duplique)
                                        //es una clase que se ocupa de que unicamente haya una instancia de esa clase
                                        //pero que ademas se pueda acceder desde cualquier lugar

    public static bool no_rep4=true;

    void Awake(){


        if(DestroyDialogC4.inst==null ){
            //primera vez. Por lo que esta es la instancia
            DestroyDialogC4.inst = this;
            no_rep4=true;
            EsconderTexto.boton_no=false;
        

            DontDestroyOnLoad(gameObject);          //Se crea una nueva escena que no se 
                                                //destruye nunca y mete el objeto en ella
            
        }
        
        else{
            //ya hay una instancia.Eliminar esta
            Destroy(gameObject);
            no_rep4=false;

        }

    }
}