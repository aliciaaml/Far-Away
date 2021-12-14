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

    //Vector2 pos;
    //public GameObject personaje;
    //PlayerController personaje;

    void Start(){
         //PlayerController personaje = gameObject.GetComponent<PlayerController>();
    }

    void Update(){
        /*
        if (SceneManager.GetActiveScene().name=="Nivel1Exterior"){
            pos=new Vector2(-3.02f,-1.3f);
            personaje.gameObject.transform.position=pos;
        }
        if (SceneManager.GetActiveScene().name=="Nivel2Exterior"){
            pos=new Vector2(-8.84f,-1.74f);
            personaje.gameObject.transform.position=pos;
        }
         if (SceneManager.GetActiveScene().name=="Nivel3Exterior"){
            pos=new Vector2(15.65f,-1.87f);
            personaje.gameObject.transform.position=pos;
        }

       */ 
    }

    public void LoadScene(string sceneName)
    {
        escenaAnterior = SceneManager.GetActiveScene().name;
        escenaActual = sceneName;
        SceneManager.LoadScene(sceneName);
    }

    public void volverAAnterior(){
        SceneManager.LoadScene(escenaAnterior);
    }

}
