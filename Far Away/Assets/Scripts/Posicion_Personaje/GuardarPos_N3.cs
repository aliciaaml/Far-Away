using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuardarPos_N3 : MonoBehaviour
{
    public static Vector2 pos;
    public Button yourButton3;

    public static bool pulsado;

 

    // Start is called before the first frame update
    void Start()
    {
        pulsado=false;
        Button btn = yourButton3.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){

        if(gameObject.transform.name== "Nivel3"&& Inventory.contador>=4){

            if (PlayerController.escena!="Nivel3Exterior"){
                pos=new Vector2(15.65f,-1.9f);
                pulsado=true;
            }

            else{
                pulsado=false;
            }   
        }
      
		   
	}
}
