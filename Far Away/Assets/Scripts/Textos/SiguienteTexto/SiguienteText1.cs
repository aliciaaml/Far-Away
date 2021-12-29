using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiguienteText1 : MonoBehaviour
{

    public GameObject dialogo2;
    public GameObject dialogo3;

    public Button yourButton;

    public static bool texto1;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

        texto1=false;
        
    }


    void TaskOnClick(){

        if(!EsconderTexto.run){
            //if(DestroyDialoN1.no_rep1){
            if(dialogo3.activeInHierarchy==false){
                dialogo3.SetActive(true);

                if(Aclaraciones.aclar)
                    texto1=true;
            }
               
         
        }
       
        
    }
}
