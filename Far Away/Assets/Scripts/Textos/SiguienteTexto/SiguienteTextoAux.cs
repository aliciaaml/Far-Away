using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiguienteTextoAux : MonoBehaviour
{
    public GameObject dialogo2;
    public GameObject dialogo3;

    public Button yourButton;

    public static bool textaux;

  

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

        textaux=false;

   
        
    }


    void TaskOnClick(){

        if(!EsconderTexto.run){
            //if(DestroyDialoN2.no_rep1){
            if(dialogo3.activeInHierarchy==false){
                dialogo3.SetActive(true);
                if(Aclaraciones.aclar)
                    textaux=true;
            }
                    
                    
                
            
        }
       
        
    }
}