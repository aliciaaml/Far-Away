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
