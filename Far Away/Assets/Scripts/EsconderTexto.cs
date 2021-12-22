using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EsconderTexto : MonoBehaviour
{

    public Button yourButton;
    public GameObject dialog;

    public static bool AnimSalida=false;

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
            StartCoroutine(Transiciona());
            AnimSalida=true;
            boton_no=true;
            PlayerController.puerta_bloq=true;
            
        }
   
    }

    IEnumerator Transiciona()
    {   
     
        yield return new WaitForSeconds(1);
        dialog.SetActive(false);
        
    }
   
}
