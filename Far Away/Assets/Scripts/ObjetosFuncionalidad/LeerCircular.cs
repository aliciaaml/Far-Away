using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeerCircular : MonoBehaviour
{
    public GameObject leer_circular;
    public GameObject boton_circular;
    public Button yourButton;

    void Start(){
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
        ControlDeDialogo.circular=false;
        leer_circular.SetActive(false);
        boton_circular.SetActive(false);
    }
}
