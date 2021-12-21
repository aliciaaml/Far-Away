using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EsconderTexto : MonoBehaviour
{

    public Button yourButton;
    public GameObject dialog;

    public static bool boton_no;

    public static bool run;

    void Start()
    {
        boton_no=false;
        run=true;
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
    }


    void TaskOnClick(){

        if(!run){
            boton_no=true;
            dialog.SetActive(false);
            PlayerController.puerta_bloq=true;
        }
   
    }
   
}
