using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class posicion_anterior : MonoBehaviour
{

   public Button yourButton;
   public static bool reglas;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        reglas=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick(){

       // Debug.Log("tacado");
        SceneManager.LoadScene(NoDistroy.escena_ant);
        reglas=false;
    }
}
