using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiguienteText10 : MonoBehaviour
{
    public GameObject dialogo2;
    public GameObject dialogo3;

    public Button yourButton;
    public static bool  texto10=false;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
    }


    void TaskOnClick(){

        if(!EsconderTexto.run){
            if(DestroyDialoN1.no_rep1){
                if(dialogo3.activeInHierarchy==false)
                    dialogo3.SetActive(true);
                    texto10=true;
                    
                
            }
        }
       
        
    }
}
