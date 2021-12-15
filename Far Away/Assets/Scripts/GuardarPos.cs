using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GuardarPos : MonoBehaviour
{
    public static Vector2 pos;
    public Button yourButton;

    public static bool pulsado;


    

    // Start is called before the first frame update
    void Start()
    {
        pulsado=false;
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){

        if (PlayerController.escena!="Nivel1Exterior"){
            pos=new Vector2(-3.02f,-1.3f);
            pulsado=true;
            Debug.Log ("You have clicked the button!");
        }

        else{
            pulsado=false;
        }
		   
	}
}
