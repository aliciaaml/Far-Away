using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiguienteText2 : MonoBehaviour
{
    public GameObject dialogoIglesia;
    public GameObject dialogo3;

    public Button yourButton;

    public static bool texto2;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

        texto2=false;
        
    }


    void TaskOnClick(){

        if(!EsconderTexto.run){
            //if(DestroyDialoN2.no_rep1){
            if(dialogo3.activeInHierarchy==false){
                dialogo3.SetActive(true);

                if(Aclaraciones.aclar)
                    texto2=true;
            }
                    
                    
                
            
        }
       
        
    }
}
