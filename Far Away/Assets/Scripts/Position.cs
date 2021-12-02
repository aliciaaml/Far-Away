using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{

    public static Vector2 posAux;
    //public GameObject personaje;

    public static Position inst;        //singleton (se encarga de que solo haya una instancia y que no se duplique)
                                        //es una clase que se ocupa de que unicamente haya una instancia de esa clase
                                        //pero que ademas se pueda acceder desde cualquier lugar
    void Awake(){


        if(Position.inst==null){
            //primera vez. Por lo que esta es la instancia
            Position.inst = this;


            DontDestroyOnLoad(gameObject);          //Se crea una nueva escena que no se 
                                                //destruye nunca y mete el objeto en ella

            
        }
        
        else{
            //ya hay una instancia.Eliminar esta
            Destroy(gameObject);
        }

        


    }
    // Update is called once per frame
    void Update()
    {
        posAux = PlayerController.guardar_pos;
    }

}
