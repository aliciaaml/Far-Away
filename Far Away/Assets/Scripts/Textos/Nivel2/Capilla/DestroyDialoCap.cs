using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDialoCap : MonoBehaviour
{
    public static DestroyDialoCap inst;        //singleton (se encarga de que solo haya una instancia y que no se duplique)
                                        //es una clase que se ocupa de que unicamente haya una instancia de esa clase
                                        //pero que ademas se pueda acceder desde cualquier lugar

    public static bool no_repCap=true;

    void Awake(){


        if(DestroyDialoCap.inst==null ){
            //primera vez. Por lo que esta es la instancia
            DestroyDialoCap.inst = this;
            no_repCap=true;
            EsconderTexto.boton_no=false;
            
            SiguienteText1.segundoTexto=false;
            SiguienteText10.texto10=false;

            DontDestroyOnLoad(gameObject);          //Se crea una nueva escena que no se 
                                                //destruye nunca y mete el objeto en ella
            
        }
        
        else{
            //ya hay una instancia.Eliminar esta
            Destroy(gameObject);
            no_repCap=false;

        }

    }
}