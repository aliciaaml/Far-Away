using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NombreDialogo : MonoBehaviour
{
    private TextMeshProUGUI nombre;
    // Start is called before the first frame update
    void Start()
    {
        nombre = GetComponent<TextMeshProUGUI>();
        nombre.text = NombrePersonaje.theName;
        Debug.Log(NombrePersonaje.theName);
        //nombre.text = "juanito";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
