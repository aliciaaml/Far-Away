using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoDistroy : MonoBehaviour
{

    public static string escena_ant;

    public static bool no_rep=true; //dialogo no reproducido

    public static float posAux;
    //public GameObject personaje;

    public static NoDistroy inst;        //singleton (se encarga de que solo haya una instancia y que no se duplique)
                                        //es una clase que se ocupa de que unicamente haya una instancia de esa clase
                                        //pero que ademas se pueda acceder desde cualquier lugar


    void Awake(){


        if(NoDistroy.inst==null ){
            //primera vez. Por lo que esta es la instancia
            NoDistroy.inst = this;
            no_rep=true;

            DontDestroyOnLoad(gameObject);          //Se crea una nueva escena que no se 
                                                //destruye nunca y mete el objeto en ella
            
        }
        
        else{
            //ya hay una instancia.Eliminar esta
            Destroy(gameObject);
            no_rep=false;

        }

    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("space") &&  EsconderTexto.boton_no){
            SceneManager.LoadScene ("Reglas", LoadSceneMode.Single );
        }
        else{
            
            if(posicion_anterior.reglas==false){

                escena_ant=SceneManager.GetActiveScene().name;
                Debug.Log(escena_ant);
            }
                
        }
            
        
    }

}
