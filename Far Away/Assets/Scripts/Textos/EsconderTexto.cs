using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EsconderTexto : MonoBehaviour
{

    public Button yourButton;
    public GameObject dialog;

    public static bool boton_no=false;

    public static bool run;


    Animator anim;

    public static int num_textos=0;

    void Start()
    {
        run=true;
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        anim=gameObject.GetComponent<Animator>();

        
        
    }

    void Update(){

        if(run)
            boton_no=false;
    }

    void TaskOnClick(){

        if(!run){

            anim.SetTrigger("salir");
            StartCoroutine(Transiciona());
            boton_no=true;
            
            num_textos+=1;
  
        }

    }

    IEnumerator Transiciona()
    {   
        yield return new WaitForSeconds(1);
        dialog.SetActive(false);
        
    }
   
}
