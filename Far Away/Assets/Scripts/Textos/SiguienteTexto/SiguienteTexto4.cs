using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiguienteTexto4 : MonoBehaviour
{

    public GameObject dialogo2;
    public GameObject dialogo3;

    public Button yourButton;

    public static bool texto4;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

        texto4=false;
        
    }


    void TaskOnClick(){

        if(!EsconderTexto.run){
            //if(DestroyDialoN1.no_rep1){
            if(dialogo3.activeInHierarchy==false){
                dialogo3.SetActive(true);
                if(Aclaraciones.aclar)
                    texto4=true;
            }
               
         
        }
       
        
    }
}
