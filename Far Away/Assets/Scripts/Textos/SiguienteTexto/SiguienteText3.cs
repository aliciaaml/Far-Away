using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiguienteText3 : MonoBehaviour
{
    public GameObject dialogo2;
    public GameObject dialogo3;

    public Button yourButton;
    public static bool  texto3;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        texto3=false;
        
    }


    void TaskOnClick(){

        if(!EsconderTexto.run){
            if(dialogo3.activeInHierarchy==false){
                dialogo3.SetActive(true);

                if(Aclaraciones.aclar)
                    texto3=true;
            }
               
       
        }
       
        
    }
}
