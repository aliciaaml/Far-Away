using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyDialoC2 : MonoBehaviour
{
    public static DestroyDialoC2 inst;        //singleton (se encarga de que solo haya una instancia y que no se duplique)
                                        //es una clase que se ocupa de que unicamente haya una instancia de esa clase
                                        //pero que ademas se pueda acceder desde cualquier lugar

    public static bool no_rep2=true;

    public static bool casa4=false;

    void Awake(){


        if(DestroyDialoC2.inst==null ){
            //primera vez. Por lo que esta es la instancia
            DestroyDialoC2.inst = this;
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

    void Update(){

        if(SceneManager.GetActiveScene().name=="Casa4"){
            casa4=true;
        }

    }
}