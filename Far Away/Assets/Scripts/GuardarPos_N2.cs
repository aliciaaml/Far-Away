using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuardarPos_N2 : MonoBehaviour
{
    public static Vector2 pos;
    public Button yourButton2;

    public static bool pulsado;

  

    // Start is called before the first frame update
    void Start()
    {
        pulsado=false;
        Button btn = yourButton2.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
        if (PlayerController.escena!="Nivel2Exterior"){
            pos=new Vector2(-8.84f,-1.74f);
            pulsado=true;
            Debug.Log ("You have clicked the button 2 !");

        }

        else{

            pulsado=false;
        }
		   
	}
}
