using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorController : MonoBehaviour
{
    public string sceneName;
    public GameObject panel;

    public bool locked {get{return isLocked;}}
    public bool isLocked;

    void changeState(){
        isLocked = !isLocked;
        instructionControllerTEXT text = gameObject.GetComponent<instructionControllerTEXT>();
        text.changeText();
    }

    public void displayInstructions(){
        panel.SetActive(true);

    }

    public void hideInstructions(){
        panel.SetActive(false);      
    }
}
