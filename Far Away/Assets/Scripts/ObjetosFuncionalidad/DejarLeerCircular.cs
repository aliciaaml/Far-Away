using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DejarLeerCircular : MonoBehaviour
{
    public GameObject leer;
    public GameObject boton;
    public Button yourButton;

    void Start(){
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }
    
    void TaskOnClick(){
        leer.SetActive(false);
        boton.SetActive(false);
    }
    
}
