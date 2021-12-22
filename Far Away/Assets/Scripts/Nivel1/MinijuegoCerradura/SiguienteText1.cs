using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiguienteText1 : MonoBehaviour
{

    public GameObject dialogo2;
    public GameObject dialogo3;

    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
    }


    void TaskOnClick(){

        if(!EsconderTexto.run){
            if(NoDistroy.no_rep){
                if(dialogo3.activeInHierarchy==false)
                    dialogo3.SetActive(true);
                
            }
        }
       
        
    }
}
