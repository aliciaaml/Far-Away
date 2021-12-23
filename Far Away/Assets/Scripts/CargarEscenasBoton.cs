using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CargarEscenasBoton : MonoBehaviour
{
    public Image theButton; // Aquí se pone el mismo botón que tenga este script
    public static string escenaActual;
    public static string escenaAnterior;

    public static bool nivel2_bloq=false;
    public static bool nivel3_bloq=false;


    void Start(){

    }

    void Update(){

    }

    public void LoadScene(string sceneName)
    {
        escenaAnterior = SceneManager.GetActiveScene().name;
        escenaActual = sceneName;

        if(gameObject.transform.name== "Nivel2" && Inventory.contador<2){

            Debug.Log("No puedes pasar al NIVEL 2 todavía");
            nivel2_bloq=true;
            EsconderTexto.boton_no=false;
        }

        if(gameObject.transform.name== "Nivel2" && Inventory.contador>=2){

             SceneManager.LoadScene(sceneName);
             nivel2_bloq=false;
        }

        

        if(gameObject.transform.name== "Nivel3"&& Inventory.contador<4){

            Debug.Log("No puedes pasar al NIVEL 3 todavía");
            nivel3_bloq=true;
            EsconderTexto.boton_no=false;
        }

        if(gameObject.transform.name== "Nivel3" && Inventory.contador>=4){

             nivel3_bloq=false;
             SceneManager.LoadScene(sceneName);
             
        }
            

        if(gameObject.transform.name!= "Nivel2" && gameObject.transform.name!= "Nivel3" )
            SceneManager.LoadScene(sceneName);
    }

    public void volverAAnterior(){
        SceneManager.LoadScene(escenaAnterior);
    }

}
