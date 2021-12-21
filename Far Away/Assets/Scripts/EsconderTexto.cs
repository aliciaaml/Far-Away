using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EsconderTexto : MonoBehaviour
{

    public Button yourButton;
    public GameObject dialog;

    public static bool boton_no;

    void Start()
    {
        boton_no=false;
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
    }


    void TaskOnClick(){
        boton_no=true;
        dialog.SetActive(false);
    }
   
}
