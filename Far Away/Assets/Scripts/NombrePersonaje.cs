using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NombrePersonaje : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    //public GameObject textDisplay;

    public void GuardarNombre()
    {
        theName = inputField.GetComponent<Text>().text;
        //textDisplay.GetComponent<Text>().text = "Bienvenido" + theName + ",disfruta de Far Away"; 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
